using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Status : MonoBehaviour
{
    public Enemy_Ctrl Enemy_Ctrl;
    [SerializeField] private int hp = 3;
    private void Awake()
    {
        Enemy_Ctrl = GetComponent<Enemy_Ctrl>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void EnemyDestroy()
    {
        Destroy(gameObject);
    }
    public virtual void EnemyLossBlood(int Damage)
    {
        this.hp -= Damage;
    }

    public virtual bool EnemyIsDead()
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
