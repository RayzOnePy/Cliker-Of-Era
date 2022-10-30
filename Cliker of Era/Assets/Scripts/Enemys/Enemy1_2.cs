using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1_2 : MonoBehaviour
{
    private void Start() {
        MainEnemy enemy = GetComponent<MainEnemy>();
        MainEnemy.hp = 35;
        MainEnemy.maxHp = 35;
        MainEnemy.isBoss = false;
        enemy.expReward = 3;
        enemy.moneyReward = 3;
        MainEnemy.indexOfEnemy = 1;
    }
    private void Update() {
        Debug.Log(MainEnemy.counterKills[MainEnemy.indexOfEnemy]);
    }
}
