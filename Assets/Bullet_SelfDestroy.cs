using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_SelfDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroy", 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Destroy()
    {
        Destroy(gameObject);
    }
}
