using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Damege : MonoBehaviour
{
    public Enemy_Ctrl Enemy_Ctrl;
    private void Awake()
    {
        this.Enemy_Ctrl = GetComponent<Enemy_Ctrl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Player_status player_Status = collision.GetComponent<Player_status>();
            player_Status.LossBlood(1);

            // enemy tu huy sau khi cham vao player
            this.Enemy_Ctrl.Enemy_Status.EnemyDestroy();
            
        }

        if(collision.CompareTag("BombPrefabs"))
        {
            Enemy_Status enemy_Status = collision.GetComponent<Enemy_Status>();
            this.Enemy_Ctrl.Enemy_Status.EnemyLossBlood(1);

            if(this.Enemy_Ctrl.Enemy_Status.EnemyIsDead())
            {
                EffectManager.instance.SpawnEffect("Explosion_A", transform.position, transform.rotation);
                Destroy(gameObject);
            }    

            
        }    


    }
    
}
