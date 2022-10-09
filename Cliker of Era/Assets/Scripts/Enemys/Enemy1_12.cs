using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1_12 : MonoBehaviour
{
    private void Start() {
        MainEnemy enemy = GetComponent<MainEnemy>();
        MainEnemy.hp = 5000;
        MainEnemy.maxHp = 5000;
        MainEnemy.isBoss = true;
        enemy.expReward = 1000;
        enemy.moneyReward = 1000;
        MainEnemy.indexOfEnemy = 11;
    }
}
