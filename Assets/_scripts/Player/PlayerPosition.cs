using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    public GameObject BombPrefabs;
    public List<GameObject> Bombs;
    // Start is called before the first frame update
    protected float SpawnTimer = 0f;
    protected float SpawnDelay = 2f;

    private void Awake()
    {
        this.BombPrefabs = GameObject.Find("BombPrefabs");
        this.Bombs = new List<GameObject>();
        this.BombPrefabs.SetActive(false);
    }

    private void Update()
    {
        this.CheckBombDead();
        this.Spawn();
    }

    protected virtual void Spawn()
    {
        this.SpawnTimer += Time.deltaTime;
        if (this.SpawnTimer < this.SpawnDelay) return;
        else this.SpawnTimer = 0;

        if (this.Bombs.Count > 7) return;

        int index = this.Bombs.Count + 1;
        GameObject Bomb_create = Instantiate(BombPrefabs);
        Bomb_create.transform.position = transform.position;
        Bomb_create.name = "BombPrefabs #" + index;
        Bomb_create.SetActive(true);
        this.Bombs.Add(Bomb_create);
        
    }    

    void CheckBombDead()
    {
        GameObject BombPrefabs;
        for (int i = 0; i < this.Bombs.Count;i++)
        {
            BombPrefabs = this.Bombs[i];
            if (BombPrefabs == null) this.Bombs.RemoveAt(i);
        }
    }
}
