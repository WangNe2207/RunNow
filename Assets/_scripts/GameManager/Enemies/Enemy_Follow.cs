using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Follow : MonoBehaviour
{
    public Transform player;
    [SerializeField]private float _followSpeed = 27f;
    [SerializeField]private float _distanceLimit = 6f;
    protected float RandPos;

    // Update is called once per frame


    private void Awake()
    {
        this.player = Player_ctrl.instance.transform;
        this.RandPos = Random.Range(-6, 6);
    }
    /*
    void Update()
    {
        this.FollowPlayer();
    }
    */

    private void FixedUpdate()
    {
        this.FollowPlayer();
    }


    protected virtual void FollowPlayer()
    {
        Vector3 Pos = this.player.transform.position;
        Pos.x = RandPos;
        Vector3 distance = Pos - transform.position;
        if (distance.magnitude >= this._distanceLimit)
        {
            Vector3 targetPoint = Pos - distance.normalized * this._distanceLimit;
            gameObject.transform.position =
                Vector3.MoveTowards(gameObject.transform.position, targetPoint, this._followSpeed * Time.deltaTime);
        }
    }
}
