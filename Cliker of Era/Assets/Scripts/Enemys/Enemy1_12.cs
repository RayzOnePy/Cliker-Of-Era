using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1_12 : MonoBehaviour
{
    private void Start() {
        MainEnemy enemy = GetComponent<MainEnemy>();
        MainEnemy.hp = 10;
        MainEnemy.maxHp = 10;
        MainEnemy.isBoss = true;
        enemy.expReward = 1;
        enemy.moneyReward = 1;
        MainEnemy.indexOfEnemy = 11;
    }
}
