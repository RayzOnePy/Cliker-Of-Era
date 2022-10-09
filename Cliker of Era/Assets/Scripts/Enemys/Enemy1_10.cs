using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1_10 : MonoBehaviour
{
    private void Start() {
        MainEnemy enemy = GetComponent<MainEnemy>();
        MainEnemy.hp = 1600;
        MainEnemy.maxHp = 1600;
        MainEnemy.isBoss = false;
        enemy.expReward = 160;
        enemy.moneyReward = 160;
        MainEnemy.indexOfEnemy = 9;
    }
}
