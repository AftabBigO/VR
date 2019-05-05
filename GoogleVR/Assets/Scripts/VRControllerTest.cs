using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRControllerTest : MonoBehaviour
{
    [SerializeField] private Transform cubeTransform;
    [SerializeField] private float speed;
    [SerializeField] private Transform cubeMovePoint;
    private float distantToJourney, distantJournied,distantJourniedFraction, journeySpeed=1.0f, journeyStartTime;
    private bool isTriggerdReticlePoint, isJourneyStarted;

    private void Update()
    {
        if(isTriggerdReticlePoint)
        {
            //RotateCube();
            MoveCube();
        }
    }

    private void RotateCube()
    {
        //cubeTransform.Rotate(Vector3.up * speed * Time.deltaTime);
        cubeTransform.Rotate(5f,8f,11f,Space.Self);
    }

    private void MoveCube()
    {
        distantJournied = (Time.time - journeyStartTime) * journeySpeed;
        distantJourniedFraction = distantJournied / distantToJourney;
        cubeTransform.position = Vector3.Lerp(cubeTransform.position, cubeMovePoint.position, distantJourniedFraction);
    }

    public void TriggerRotate()
    {
        isTriggerdReticlePoint =(!isTriggerdReticlePoint);
        if(isTriggerdReticlePoint)
        {
            journeyStartTime = Time.time;
            distantToJourney =Vector3.Distance(cubeMovePoint.position, cubeTransform.position);
        }
    }       
}