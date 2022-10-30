using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;
public class CameraMove : MonoBehaviour
{
    public Vector3 offset = new Vector3(0, 0, 0);
    public Camera mainCamera;
    public float touchRotateSpeed = 4f;
    [Tooltip("Smaller positive value means smoother rotation, 1 means no smooth apply")]
    public float slerpValue = 0.25f; 

    private Vector2 swipeDirection = new Vector2(0, 5); //swipe delta vector2
    private Quaternion cameraRot; // store the quaternion after the slerp operation
    private Touch touch;
    float diffrence = -40f;
    private float distanceBetweenCameraAndTarget;

    public static float minXRotAngle = 5; //min angle around x axis
    private float maxXRotAngle  = 55; // max angle around x axis
    Vector3 dir = new Vector3(0, 0, -25);
    private void Start() {
        mainCamera.transform.position = new Vector3(0, 5, 0);
    }

    void Update()
    {
            if (Input.touchCount == 1){
                touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Moved){
                    swipeDirection -= touch.deltaPosition * Time.deltaTime * touchRotateSpeed;
                }

                if (swipeDirection.y < minXRotAngle){
                    swipeDirection.y = minXRotAngle;
                }else if (swipeDirection.y > maxXRotAngle){
                    swipeDirection.y = maxXRotAngle;
                }
            }else if (Input.touchCount == 2){
                Touch touchOne = Input.GetTouch(0);
                Touch touchTwo = Input.GetTouch(1);

                Vector3 touchOneDelta = touchOne.position - touchOne.deltaPosition;
                Vector3 touchTwoDelta = touchTwo.position - touchTwo.deltaPosition;

                float touchDelta = (touchOneDelta - touchTwoDelta).magnitude;
                float distTouch = (touchOne.position - touchTwo.position).magnitude;
                
                diffrence = Mathf.Clamp(diffrence + ((distTouch - touchDelta) * 0.03f), -50, -20);

                dir = new Vector3(0, 0, diffrence);
            }
    }

    private void LateUpdate()
    
    {
        Quaternion newQ = Quaternion.Euler(swipeDirection.y , -swipeDirection.x, 0);
        cameraRot = Quaternion.Slerp(cameraRot, newQ, slerpValue);
        mainCamera.transform.position = cameraRot * dir;
        mainCamera.transform.LookAt(new Vector3(0, 0, 0));
    }
}
