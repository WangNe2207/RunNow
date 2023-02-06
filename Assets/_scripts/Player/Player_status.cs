using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_status : MonoBehaviour
{
    public Player_ctrl player_ctrl;
    [SerializeField]private int hp = 10;
    // Start is called before the first frame update
    private void Awake()
    {
        player_ctrl = GetComponent<Player_ctrl>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this.CheckDead();
    }
    /*
    public virtual void CheckDead()
    {
        if(IsDead())
        {
            Dead();
        }
    }
    */
    
    public virtual void LossBlood(int Damage)
    {
        this.hp -= Damage;
    }

    public virtual bool IsDead()
    {
        return hp <= 0;
    }    

    public virtual void Dead()
    {
        Debug.Log("Dead");
    }    
    public int GetHP()
    {
        return this.hp;
    }    
    public void SetHP(int Value)
    {
        this.hp = Value;
    }    
}
