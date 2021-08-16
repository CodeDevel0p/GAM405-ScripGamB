using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Debug.Log(horizontal + ", " + vertical);

        //Is any key currently held down (Includes mouse buttons)
        if(Input.anyKey)
        {

        }

        if (Input.GetMouseButton(0))
        {
            Debug.Log(Input.mousePosition);
        }

        //Demonstrations with Keys.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Key Down - Cube has Jumped");
        }
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Key is being held - Cube is in the middle of jumping");
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log(("Key Up - Cube now falling down"));
        }
        

        //Demonstration with Buttons 

        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Buton Down - Cube has Jumped");
        }
        if (Input.GetButton("Jump"))
        {
            Debug.Log("Button is being held - Cube is in the middle of jumping");
        }
        if (Input.GetButtonUp("Jump"))
        {
            Debug.Log(("Button Up - Cube now falling down"));
        }

    }
}
