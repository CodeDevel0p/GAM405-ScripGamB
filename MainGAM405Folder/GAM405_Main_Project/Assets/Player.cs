using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[SerializeField]
public class Player : Character
{
    
    new public float health = 6;
    new public float moveSpeed = 1;
    new public float jumpHeight = 1;
    new public float throwDistance = 1;
    private float playerVelocity = 8;
    public string returnMenuPress = "MainMenuScene";
    
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Health = " + health + " Move Speed = " + moveSpeed + " Jump Height = " + jumpHeight + " ThrowDistance = " + throwDistance);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerControls();
    }
    
    public override void InitialStats()
    {
        health = 6; moveSpeed = 1; jumpHeight = 1; throwDistance = 2;
        Debug.Log("Health = " + health + " Move Speed = " + moveSpeed + " Jump Height = " + jumpHeight + " ThrowDistance = " + throwDistance);
    } 

    //Contains all the player's movement and controls.
    public void PlayerControls ()
    {
        //Moves the player to the right
        if (Input.GetKeyDown(KeyCode.D))
        {

            GetComponent<Transform>().Translate(Vector3.right * moveSpeed);
        }
        //Moves player to the left
        if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<Transform>().Translate(Vector3.left * moveSpeed);
        }

        //Performs a jump
        if (Input.GetKeyDown(KeyCode.Space))
        {

        }

        //Launches the player into the air
        if (Input.GetKeyDown(KeyCode.Q))
        {

        }

        //Player will grab an object
        if (Input.GetKeyDown(KeyCode.R))
        {

        }

        //Throws an object.
        if (Input.GetKeyDown(KeyCode.T))
        {

        }

        //Return to the main menu and reset progress
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(returnMenuPress);
        }
    }
}
