using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1_5 : MonoBehaviour
{
    private void Start() {
        MainEnemy enemy = GetComponent<MainEnemy>();
        MainEnemy.hp = 225;
        MainEnemy.maxHp = 225;
        MainEnemy.isBoss = false;
        enemy.expReward = 20;
        enemy.moneyReward = 20;
        MainEnemy.indexOfEnemy = 4;
    }
}
