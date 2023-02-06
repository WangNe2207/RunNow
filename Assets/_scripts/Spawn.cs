using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [Header("Spawn")]
    public List<GameObject> Obj;
    public GameObject SpawnPos;
    public GameObject ObjPrefabs;
    public float SpawnTimer = 0f;
    public float SpawnDelay = 0.2f;
    public string SpawnPosName = "";
    public string PrefabsName = "";
    public int MaxObj = 1;
    public int OrderLayer = 10;
    private void Awake()
    {
        this.SpawnPos = GameObject.Find(this.SpawnPosName);
        this.ObjPrefabs = GameObject.Find(this.PrefabsName);
        this.Obj = new List<GameObject>();
        this.ObjPrefabs.SetActive(false);
        this.OrderLayer = (int)this.ObjPrefabs.transform.position.z;
    }
    private void Update()
    {
        this.CheckDead();
        this.SpawnObj();
    }

    protected virtual void CheckDead()
    {
        GameObject BombPrefabs;
        for (int i = 0; i < this.Obj.Count; i++)
        {
            BombPrefabs = this.Obj[i];
            if (BombPrefabs == null) this.Obj.RemoveAt(i);
        }
    }

    protected virtual void SpawnObj()
    {
        if (Player_ctrl.instance.player_Status.IsDead()) return;

        this.SpawnTimer += Time.deltaTime;
        if (this.SpawnTimer < this.SpawnDelay) return;
        else this.SpawnTimer = 0;

        if (this.Obj.Count >= this.MaxObj) return;

        Vector3 Pos = this.SpawnPos.transform.position;
        Pos.z = this.OrderLayer;

        SpawnObj(Pos);

    }
    protected virtual void SpawnObj(Vector3 Pos)
    {
        GameObject enemy = Instantiate(ObjPrefabs);
        enemy.transform.position = Pos;
        enemy.SetActive(true);
        enemy.transform.parent = transform;

        this.Obj.Add(enemy);
    }    

}
