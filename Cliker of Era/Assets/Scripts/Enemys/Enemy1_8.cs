using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1_8 : MonoBehaviour
{
    private void Start() {
        MainEnemy enemy = GetComponent<MainEnemy>();
        MainEnemy.hp = 1200;
        MainEnemy.maxHp = 1200;
        MainEnemy.isBoss = true;
        enemy.expReward = 150;
        enemy.moneyReward = 150;
        MainEnemy.indexOfEnemy = 7;
    }
}
