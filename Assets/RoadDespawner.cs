using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadDespawner : MonoBehaviour
{
    protected float Distance = 0;
    private void FixedUpdate()
    {
        this.UpdateRoad();
    }

    protected void UpdateRoad()
    {
        this.Distance = Vector2.Distance(Player_ctrl.instance.transform.position, transform.position);
        if (this.Distance > 70) this.DespawnRoad();
    }

    protected void DespawnRoad()
    {
        Destroy(gameObject);
    }
}
