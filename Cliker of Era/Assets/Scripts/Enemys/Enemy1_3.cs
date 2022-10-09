using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1_3 : MonoBehaviour
{
    private void Start() {
        MainEnemy enemy = GetComponent<MainEnemy>();
        MainEnemy.hp = 80;
        MainEnemy.maxHp = 80;
        MainEnemy.isBoss = false;
        enemy.expReward = 5;
        enemy.moneyReward = 5;
        MainEnemy.indexOfEnemy = 2;
    }
}
