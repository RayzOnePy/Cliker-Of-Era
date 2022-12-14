using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SwitchEnemy : MonoBehaviour
{
    public TextMeshProUGUI kills;
    public GameObject[] enemys;
    private GameObject enemy;
    void Update()
    {
        if (MainEnemy.isBoss){
            if (MainEnemy.counterKills[MainEnemy.indexOfEnemy] <= 1){
                kills.text = $"{MainEnemy.counterKills[MainEnemy.indexOfEnemy]} / 1";
            }
        }
        else{
            if (MainEnemy.counterKills[MainEnemy.indexOfEnemy] <= 10){
                kills.text = $"{MainEnemy.counterKills[MainEnemy.indexOfEnemy]} / 10";
            }  
            else {
                kills.text = $"10 / 10";
            }
        } 
    }
    public void NextEnemy(){
        if (MainEnemy.counterKills[MainEnemy.indexOfEnemy] >= 10 && MainEnemy.indexOfEnemy <= 10){
            enemy = GameObject.FindGameObjectWithTag("Enemy");
            Destroy(enemy);
            Instantiate(enemys[MainEnemy.indexOfEnemy + 1], new Vector3(0, 5f, 0), Quaternion.Euler(0, 0, 0));
        }
        if (MainEnemy.isBoss && MainEnemy.counterKills[MainEnemy.indexOfEnemy] >= 1){
            enemy = GameObject.FindGameObjectWithTag("Enemy");
            Destroy(enemy);
            Instantiate(enemys[MainEnemy.indexOfEnemy + 1], new Vector3(0, 5f, 0), Quaternion.Euler(0, 0, 0));
        }
    }
    public void PreviousEnemy(){
        if (MainEnemy.indexOfEnemy >= 1){
            enemy = GameObject.FindGameObjectWithTag("Enemy");
            Destroy(enemy);
            Instantiate(enemys[MainEnemy.indexOfEnemy - 1], new Vector3(0, 5f, 0), Quaternion.Euler(0, 0, 0));
        }
    }
}
