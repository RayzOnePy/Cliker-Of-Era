using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SwitchEnemy : MonoBehaviour
{
    public TextMeshProUGUI kills;
    public GameObject enemy;
    void Update()
    {
        if (enemy.GetComponent<MainEnemy>().counterKills[enemy.GetComponent<MainEnemy>().indexOfEnemy] <= 10){
            kills.text = $"{enemy.GetComponent<MainEnemy>().counterKills[enemy.GetComponent<MainEnemy>().indexOfEnemy]} / 10";
        }
    }
}
