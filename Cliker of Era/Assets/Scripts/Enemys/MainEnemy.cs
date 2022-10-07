using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainEnemy : MonoBehaviour
{
    public static float hp = 0;
    public static float maxHp = 0;
    public int expReward = 0;
    public int moneyReward = 0;
    public int indexOfEnemy = 0;
    public int[] counterKills = {0, 0, 0, 0, 0, 0};
    private void Update() {
        if (hp <= 0){
            hp = maxHp;
            Player.money += moneyReward;
            Player.exp += expReward;
            counterKills[indexOfEnemy] += 1;
        }
    }
    private void OnMouseDown() {
        hp -= Player.strength;
    }
}
