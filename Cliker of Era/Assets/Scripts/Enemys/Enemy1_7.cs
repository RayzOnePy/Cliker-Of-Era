using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1_7 : MonoBehaviour
{
    private void Start() {
        MainEnemy enemy = GetComponent<MainEnemy>();
        MainEnemy.hp = 520;
        MainEnemy.maxHp = 520;
        MainEnemy.isBoss = false;
        enemy.expReward = 50;
        enemy.moneyReward = 50;
        MainEnemy.indexOfEnemy = 6;
    }
}
