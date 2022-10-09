using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1_6 : MonoBehaviour
{
    private void Start() {
        MainEnemy enemy = GetComponent<MainEnemy>();
        MainEnemy.hp = 360;
        MainEnemy.maxHp = 360;
        MainEnemy.isBoss = false;
        enemy.expReward = 35;
        enemy.moneyReward = 35;
        MainEnemy.indexOfEnemy = 5;
    }
}
