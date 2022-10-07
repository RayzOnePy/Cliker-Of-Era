using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlace : MonoBehaviour
{
    public GameObject obj;
    // private void Update() {
    //     if (Input.GetMouseClick(0)){
    //         Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //         RaycastHit hit;
    //         if (Physics.Raycast(ray, out hit)){
    //             if (hit.transform.gameObject.tag == "Place"){
    //                 Debug.Log("click");
    //                 Instantiate(obj, hit.transform.position + new Vector3(0, 10f, 0), Quaternion.identity);
    //             }
    //         }
    //     }
    // }
    void OnMouseUpAsButton(){
        Debug.Log("click");
        Instantiate(obj, transform.position + new Vector3(0, 10f, 0), Quaternion.identity);
    }
}
