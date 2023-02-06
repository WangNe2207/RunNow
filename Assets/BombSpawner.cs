using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : Spawn
{
    //[Header("Bomb")]
    //protected int maxBomb = 7;
    //public List<GameObject> Obj;
    //public GameObject SpawnPos;
    //public GameObject ObjPrefabs;
    //protected float SpawnTimer = 0f;
    //protected float SpawnDelay = 2f;
    
    private void Reset()
    {
        this.SpawnPosName = "BombSpawnPos";
        this.PrefabsName = "BombPrefabs";
        this.MaxObj = 7;
    }

    /*
    private void Awake()
    {
        this.SpawnPos = GameObject.Find("BombSpawnPos");
        this.ObjPrefabs = GameObject.Find("BombPrefabs");
        this.Obj = new List<GameObject>();
        this.ObjPrefabs.SetActive(false);
    }
    */
    /*
    private void Update()
    {
        this.CheckDead();
        this.SpawnObj();
    }

    
    protected virtual void SpawnObj()
    {
        this.SpawnTimer += Time.deltaTime;
        if (this.SpawnTimer < this.SpawnDelay) return;
        else this.SpawnTimer = 0;

        if (this.Obj.Count > this.MaxObj) return;

        int index = this.Obj.Count + 1;
        GameObject Bomb_create = Instantiate(ObjPrefabs);
        Bomb_create.transform.position = this.SpawnPos.transform.position;
        Bomb_create.name = "BombPrefabs #" + index;
        Bomb_create.SetActive(true);
        this.Obj.Add(Bomb_create);
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
