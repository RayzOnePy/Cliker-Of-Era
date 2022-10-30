using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UpdateExp : MonoBehaviour
{
    public Image expBar;
    public TextMeshProUGUI lvl;
    void Update()
    {
        if (Player.exp >= Player.expMax){
            Player.exp = 0;
            Player.expMax *= 1.25f;
            Player.lvl += 1;
        }
        lvl.text = $"{Player.lvl}";
        expBar.fillAmount = Player.exp / Player.expMax;
    }
}
