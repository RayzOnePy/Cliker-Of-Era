using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1_10 : MonoBehaviour
{
    private void Start() {
        MainEnemy enemy = GetComponent<MainEnemy>();
        MainEnemy.hp = 10;
        MainEnemy.maxHp = 10;
        enemy.expReward = 1;
        enemy.moneyReward = 1;
        MainEnemy.indexOfEnemy = 9;
    }
}
