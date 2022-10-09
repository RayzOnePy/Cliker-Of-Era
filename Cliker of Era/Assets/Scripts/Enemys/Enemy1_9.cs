using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1_9 : MonoBehaviour
{
    private void Start() {
        MainEnemy enemy = GetComponent<MainEnemy>();
        MainEnemy.hp = 1000;
        MainEnemy.maxHp = 1000;
        MainEnemy.isBoss = false;
        enemy.expReward = 120;
        enemy.moneyReward = 120;
        MainEnemy.indexOfEnemy = 8;
    }
}
