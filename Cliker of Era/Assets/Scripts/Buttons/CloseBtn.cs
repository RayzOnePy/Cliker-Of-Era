using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseBtn : MonoBehaviour
{
    public GameObject buyMenu;
    public void Close(){
        buyMenu.SetActive(false);
    }
}
