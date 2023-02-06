using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Shooting : MonoBehaviour
{
    public List<GameObject> Magazine;
    public GameObject Bullet;
    public GameObject ShootingPos;
    public float SpawnTimer = 0f;
    public float SpawnDelay = 1f;
    public int OrderLayer = -10;
    public int MaxBullet = 10;
    private void Awake()
    {
        //this.Bullet = GameObject.Find("Bullet");
        //this.ShootingPos = GameObject.Find("WeaponsPos");
        this.Magazine = new List<GameObject>();
        this.Bullet.SetActive(false);
    }
    private void Update()
    {
        this.SpawnBullet();
    }
    protected virtual void SpawnBullet()
    {
        this.SpawnTimer += Time.deltaTime;
        if (this.SpawnTimer < this.SpawnDelay) return;
        else this.SpawnTimer = 0;

        Vector3 Pos = this.ShootingPos.transform.position;
        Pos.z = this.OrderLayer;
        SpawnBullet(Pos);

        if (this.Magazine.Count > this.MaxBullet) return;
    }
    protected virtual void SpawnBullet(Vector3 pos)
    {
        GameObject BulletShooting = Instantiate(Bullet);
        BulletShooting.transform.position = pos;
        BulletShooting.SetActive(true);

        this.Magazine.Add(BulletShooting);
    }


}
