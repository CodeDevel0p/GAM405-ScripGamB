using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Camera_Canvas_UserInterface : MonoBehaviour
{          
    public Text playerLives;
    public Text playerHealth;
    public Text playerMovespeed;
    public Text playerJumpHeight;
    public Text playerThrowDistance;
    public Text remainingTimeLeft;

    
    public Transform target;
    public Vector3 offsetVal;
    public float speedCamera = 0.125f;

    void LateUpdate()
    {
        transform.position = target.position + offsetVal;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
