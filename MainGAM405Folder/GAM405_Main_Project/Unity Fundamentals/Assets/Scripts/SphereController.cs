using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
         //Did we hit the ground?
         if (collision.gameObject.CompareTag("Ground"))
        {
            GroundController gcScrpt = collision.gameObject.GetComponent<GroundController>();

            gcScrpt.DisplayMessage();
        }
         else if (collision.gameObject.CompareTag("Furniture"))
            {
               Debug.Log("Collided with furniture");
            }
    }

    private void OnCollisionStay(Collision collision)
    {
        //Are we still on the ground
    }

    private void OnCollisionExit(Collision collision)
    {
        //Have we stopped colliding with the ground?
        Debug.Log("Stopped colliding with " + collision.gameObject.tag);
    }
}
