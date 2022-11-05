using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockMan : MonoBehaviour
{
    private int strength = 1;
    private RockMan main;
    private void Start() {
        transform.LookAt(GameObject.FindGameObjectWithTag("Target").transform.position);
        main = GetComponent<RockMan>();
    }
    public void RockManPunch(){
        MainEnemy.hp -= main.strength;
    }
}
