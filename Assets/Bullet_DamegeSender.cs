using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_DamegeSender : MonoBehaviour
{
    public Bullet_ctrl bullet_Ctrl;
    private void Awake()
    {
        this.bullet_Ctrl = GetComponent<Bullet_ctrl>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            //Debug.Log("dinh dan");
            this.bullet_Ctrl.bullet_SelfDestroy.Destroy();
        }
    }
}
