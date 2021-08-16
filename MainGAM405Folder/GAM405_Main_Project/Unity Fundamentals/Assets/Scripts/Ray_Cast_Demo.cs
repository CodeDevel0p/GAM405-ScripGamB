using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray_Cast_Demo : MonoBehaviour
{
    public GameObject EndPoint;
    public LayerMask RayMask;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 StartPoint = transform.position;

        //Get our end point -Determine the ray direction
        Vector3 rayDirection = EndPoint.transform.position - StartPoint;
        float maxDistance = rayDirection.magnitude;
        rayDirection /= maxDistance;


        //Here we are performing the raycast.
        RaycastHit hitInfo;
        if (Physics.Raycast(StartPoint, rayDirection, out hitInfo, maxDistance, RayMask))
        {
            Debug.Log("Hit " + hitInfo.collider.gameObject.name);
            Debug.DrawRay(StartPoint, rayDirection, Color.white, 0.4f);
        }
    }
}
