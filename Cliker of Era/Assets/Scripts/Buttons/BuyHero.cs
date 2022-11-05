using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyHero : MonoBehaviour
{
    public GameObject hero;
    public void Buy(){
        Instantiate(hero, Place.activePlace.transform.position + new Vector3(0, 2.6f, 0), Quaternion.identity);
    }
}
