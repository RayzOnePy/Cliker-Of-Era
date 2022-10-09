using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1_4 : MonoBehaviour
{
    private void Start() {
        MainEnemy enemy = GetComponent<MainEnemy>();
        MainEnemy.hp = 250;
        MainEnemy.maxHp = 250;
        MainEnemy.isBoss = true;
        enemy.expReward = 25;
        enemy.moneyReward = 25;
        MainEnemy.indexOfEnemy = 3;
    }
}
