using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1_11 : MonoBehaviour
{
    private void Start() {
        MainEnemy enemy = GetComponent<MainEnemy>();
        MainEnemy.hp = 2200;
        MainEnemy.maxHp = 2200;
        MainEnemy.isBoss = false;
        enemy.expReward = 220;
        enemy.moneyReward = 220;
        MainEnemy.indexOfEnemy = 10;
    }
}
