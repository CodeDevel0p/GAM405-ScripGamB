using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageReceiver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Message1(string value)
    {
        Debug.Log(gameObject.name + ": Message 1 -> " + value);
    }

    void Message2()
    {

    }

}
