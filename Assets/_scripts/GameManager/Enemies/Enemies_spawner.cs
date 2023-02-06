using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies_spawner : Spawn
{
    //[Header("Enemy")]
    //public List<GameObject> Obj;
    //public GameObject SpawnPos;
    //public GameObject ObjPrefabs;
    //protected int maxEnemies = 1;
    //protected float SpawnDelay = 2f;
    //protected float SpawnTimer = 0f;
    
    private void Reset()
    {
        this.SpawnPosName = "EnemySpawnPos";
        this.PrefabsName = "EnemyPrefabs";
        this.MaxObj = 1;
    }
    
    /*
    private void Awake()
    {
        this.SpawnPos = GameObject.Find("EnemySpawnPos");
        this.ObjPrefabs = GameObject.Find("EnemyPrefabs");
        this.ObjPrefabs.SetActive(false);
        this.Obj = new List<GameObject>();
    }
    */
    // Update is called once per frame
    /*
    void Update()
    {
        this.CheckDead();
        this.SpawnObj();
    }
    
    void SpawnObj()
    {
        if (Player_ctrl.instance.player_Status.IsDead()) return;

        this.SpawnTimer += Time.deltaTime;
        if (this.SpawnTimer < this.SpawnDelay) return;
        else this.SpawnTimer = 0;

        if (this.Obj.Count >= this.MaxObj) return;

        GameObject enemy = Instantiate(ObjPrefabs);
        enemy.transform.position = this.SpawnPos.transform.position;
        enemy.SetActive(true);
        enemy.transform.parent = transform;

        this.Obj.Add(enemy);
    }

    
    void CheckDead()
    {
        GameObject BombPrefabs;
        for (int i = 0; i < this.Obj.Count; i++)
        {
            BombPrefabs = this.Obj[i];
            if (BombPrefabs == null) this.Obj.RemoveAt(i);
        }
    }
    */
}
