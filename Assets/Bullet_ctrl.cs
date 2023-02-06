using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_ctrl : MonoBehaviour
{
    public Bullet_DamegeSender bullet_DamegeSender;
    public Bullet_SelfDestroy bullet_SelfDestroy;

    private void Awake()
    {
        this.bullet_DamegeSender = GetComponent<Bullet_DamegeSender>();
        this.bullet_SelfDestroy = GetComponent<Bullet_SelfDestroy>();
    }
}
