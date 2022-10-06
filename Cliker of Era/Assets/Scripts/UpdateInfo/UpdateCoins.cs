using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateCoins : MonoBehaviour
{
    public TextMeshProUGUI money;
    void Update()
    {
        money.text = $"{Player.money}";
    }
}
