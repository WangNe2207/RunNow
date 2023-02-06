using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPrefabs : MonoBehaviour
{
    void start()
    {
        Invoke("Destroy", 2f);
    }
    public void Destroy()
    {
        Destroy(gameObject); 
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            EffectManager.instance.SpawnEffect("Explosion_B", transform.position, transform.rotation);
        }
    }


}

