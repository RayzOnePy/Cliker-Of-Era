using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BossTimer : MonoBehaviour
{
    private float bossTimer = 30f;
    [SerializeField] 
    private TextMeshProUGUI timerText;
    private void Update() {
        if (MainEnemy.isBoss == true){
            timerText.gameObject.SetActive(true);
            bossTimer -= Time.deltaTime;
            timerText.text = Mathf.Round(bossTimer).ToString();
            if (bossTimer <= 0){
                MainEnemy.hp = MainEnemy.maxHp;
                bossTimer = 30f;
            }
            if (MainEnemy.hp <= 0){
                bossTimer = 30f;
            }
        }
        else{
            bossTimer = 30f;
            timerText.gameObject.SetActive(false);
        }
    }
}
