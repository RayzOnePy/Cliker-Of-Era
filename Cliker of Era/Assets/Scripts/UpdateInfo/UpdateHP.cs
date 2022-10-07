using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpdateHP : MonoBehaviour
{
    public Image hpbar;
    public TextMeshProUGUI hp;
    void Update()
    {
        hpbar.fillAmount = MainEnemy.hp / MainEnemy.maxHp;
        hp.text = $"{MainEnemy.hp}";
    }
}
