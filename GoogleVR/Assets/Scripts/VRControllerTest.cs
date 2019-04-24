using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRControllerTest : MonoBehaviour
{
    [SerializeField] private Transform cubeTransform;
    [SerializeField] private float speed;
    private bool canRotate;

    private void Update()
    {
        if(canRotate)
        {
            RotateCube();
        }
    }

    private void RotateCube()
    {
        cubeTransform.Rotate(Vector3.up * speed * Time.deltaTime);
    }

    public void TriggerRotate()
    {
        canRotate =(!canRotate);
    }       
}