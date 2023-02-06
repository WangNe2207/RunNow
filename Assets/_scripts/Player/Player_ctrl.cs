using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_ctrl : MonoBehaviour
{
    static public Player_ctrl instance;
    public Player_status player_Status;
    public Player_DamageReceiver damageReceiver;

    private void Awake()
    {
        Player_ctrl.instance = this;
        player_Status = GetComponent<Player_status>();
        damageReceiver = GetComponent<Player_DamageReceiver>();
    }
}
