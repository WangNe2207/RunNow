using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Ctrl : MonoBehaviour
{
    public Enemy_Status Enemy_Status;
    public Enemy_Damege Enemy_Damege;
    // Start is called before the first frame update
    private void Awake()
    {
        this.Enemy_Status = GetComponent<Enemy_Status>();
        this.Enemy_Damege = GetComponent<Enemy_Damege>();
    }
}
