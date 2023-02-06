using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMoveMeny : MonoBehaviour
{
    [SerializeField]private float SpeedBullet = 100f;
    //[SerializeField] private int TimeToDestroy = 5;
    Rigidbody2D m_rb;
    // Start is called before the first frame update
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
        //Destroy(gameObject, TimeToDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        m_rb.velocity = Vector3.up * SpeedBullet;
    }
}
