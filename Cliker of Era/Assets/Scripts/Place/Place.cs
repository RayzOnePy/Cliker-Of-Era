using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Place : MonoBehaviour
{
    public GameObject buyMenu;
    public static GameObject activePlace;
    void OnMouseUpAsButton(){
        buyMenu.SetActive(true);
        activePlace = this.gameObject;
    }
}
