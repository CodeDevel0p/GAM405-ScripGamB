using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPicker : MonoBehaviour
{
    public float RayCastDistance = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Have we pressed the left mouse button?
        if (Input.GetMouseButtonDown(0))
        {
            //Constructs our ray from camera to mouse position
           Ray cameraRay =  Camera.main.ScreenPointToRay(Input.mousePosition);

            //Check for hitting something
            RaycastHit infoHitRay;
            if (Physics.Raycast(cameraRay, out infoHitRay, RayCastDistance))
            {
                Debug.Log("Clicked on " + infoHitRay.collider.gameObject.name);
            }
        }

        //Have we pressed the right mouse button?
        if (Input.GetMouseButtonDown(1))
        {
            //Constructs our ray from camera to mouse position
            Vector3 screenPoint = new Vector3(Screen.width / 2f, Screen.height / 2f, 0);
            Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);

            //Check for hitting something
            RaycastHit infoHitRay;
            if (Physics.Raycast(cameraRay, out infoHitRay, RayCastDistance))
            {
                Debug.Log("Clicked on " + infoHitRay.collider.gameObject.name);
            }
        }

    }
}
