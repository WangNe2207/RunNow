using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_DamageReceiver : Player_status
{
    protected Player_ctrl player_Ctrl;

    private void Awake()
    {
        player_Ctrl = GetComponent<Player_ctrl>();
    }

    public override void LossBlood(int Damage)
    {
        base.LossBlood(Damage);
        if (this.IsDead())
        {
            this.Dead();
            UIManager.instance.BnGameOver.SetActive(true);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Bullet"))
        {
            EffectManager.instance.SpawnEffect("Explosion_C", transform.position, transform.rotation);
            this.LossBlood(1);
        }    
    }

}
