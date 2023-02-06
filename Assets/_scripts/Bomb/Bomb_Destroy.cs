using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb_Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SelfDestroy", 2f);
    }
    void SelfDestroy()
    {
        Destroy(gameObject);
    }


}
