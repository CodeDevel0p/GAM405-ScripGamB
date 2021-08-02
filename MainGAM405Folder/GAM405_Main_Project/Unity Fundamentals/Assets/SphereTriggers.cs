using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereTriggers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per framess
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Have we collided with the wall or ground?
        if (other.CompareTag("Wall"))
        {
            WallController wallController = other.gameObject.GetComponent<WallController>();
            wallController.DisplayMessage();
        }
        else if (other.CompareTag("Ground"))
        {
            Debug.Log("Hit ground");
        }
    }

    private void OnTriggerStay (Collider other)
    {

    }

    private void OnTriggerExit (Collider other)
    {
        Debug.Log("No longer overlapping with " + other.tag);
    }
}
