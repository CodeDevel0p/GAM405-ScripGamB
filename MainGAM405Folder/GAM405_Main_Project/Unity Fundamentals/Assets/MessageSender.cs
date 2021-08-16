using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageSender : MonoBehaviour
{
    public GameObject TargetObject1;
    public GameObject TargetObject2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            TargetObject1.SendMessage("Message 1", "Test 1");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            TargetObject1.SendMessageUpwards("Message 2", "Test 1");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            TargetObject1.BroadcastMessage("Message 1", "Test 3");
        }
    }
}
