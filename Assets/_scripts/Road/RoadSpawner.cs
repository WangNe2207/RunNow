using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    protected GameObject RoadPrefabs;
    protected GameObject RoadSpawnPos;
    protected GameObject RoadCurrent;
    protected float Distance = 0;
    protected int RoadOrderLayer = 10;
    private void Awake()
    {
        this.RoadPrefabs = GameObject.Find("RoadPrefabs");
        this.RoadSpawnPos = GameObject.Find("RoadSpawnPos");
        this.RoadPrefabs.SetActive(false);

        //this.RoadCurrent = this.RoadPrefabs
        this.CreateRoad(this.RoadPrefabs.transform.position);
        this.RoadOrderLayer = (int)this.RoadPrefabs.transform.position.z;
        
    }

    private void FixedUpdate()
    {
        this.UpdateRoad();
    }

    protected void UpdateRoad()
    {
        this.Distance = Vector2.Distance(Player_ctrl.instance.transform.position, this.RoadCurrent.transform.position);
        if (this.Distance > 40) this.SpawnRoad();  
    }    
    protected void SpawnRoad()
    {
        Vector3 PosSpawn = this.RoadSpawnPos.transform.position;
        PosSpawn.x = 0;
        PosSpawn.z = this.RoadOrderLayer;

        CreateRoad(PosSpawn);
        //this.RoadCurrent = Instantiate(this.RoadPrefabs,PosSpawn,this.RoadPrefabs.transform.rotation);
    }    

    protected void CreateRoad(Vector3 Position)
    {
        this.RoadCurrent = Instantiate(this.RoadPrefabs, Position, this.RoadPrefabs.transform.rotation);
        this.RoadCurrent.SetActive(true);
        this.RoadCurrent.transform.parent = transform;
    }
}
