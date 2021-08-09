using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereListener : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Display1()
    {
        Debug.Log("Sphere 1");
    }

    public void Display2(int value)
    {
        Debug.Log("Sphere 1: " + value);
    }
}
