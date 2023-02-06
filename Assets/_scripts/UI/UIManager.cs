using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    static public UIManager instance;
    public GameObject BnGameOver;

    private void Awake()
    {
        UIManager.instance = this;
        this.BnGameOver = GameObject.Find("BnGameOver");
        this.BnGameOver.SetActive(false);
    }


}
