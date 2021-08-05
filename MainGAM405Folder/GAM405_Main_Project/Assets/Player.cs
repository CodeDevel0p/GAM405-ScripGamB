using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[SerializeField]
public class Player : Character
{

    public enum MovementType
    {
         TransformPosition,
         AddForce,
         MovePosition,
         Velocity
    }

    public enum RotateType
    {
        TransformRotation
    }

    public MovementType moveType = MovementType.TransformPosition;
    public RotateType rotateType = RotateType.TransformRotation;


    public float launchDistance = 5.0f;
    new public float health = 6.0f;
    new public float moveSpeed = 1.0f;
    new public float jumpHeight = 1.0f;
    new public float throwDistance = 1;
    protected float moveHorizontal, moveVertical, jumpUp, blastLaunch;
    private float playerVelocity = 8;
    public string returnMenuPress = "MainMenuScene";
    protected Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        InitialStats();
        rb = gameObject.GetComponent<Rigidbody>();
        Debug.Log("Health = " + health + " Move Speed = " + moveSpeed + " Jump Height = " + jumpHeight + " ThrowDistance = " + throwDistance);
    }

    // Update is called once per frame
    void Update()
    {
        //Here are the inputs based on horizontal and vertical inputs, instead of the WASD format.
        moveHorizontal = Input.GetAxis("Horizontal");
        
        moveVertical = Input.GetAxis("Vertical");
        jumpUp = moveVertical;

        //Move forwards at a certain speed by the transform
        if (moveType == MovementType.TransformPosition)
        {
            transform.position += new Vector3((moveHorizontal * moveSpeed), 0, 0) * moveSpeed * Time.deltaTime;
        }
        //When the player jumps
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
        }
    }

    public void FixedUpdate()
    {

    }
    
    public override void InitialStats()
    {
        health = 6; moveSpeed = 3; jumpHeight = 3; throwDistance = 2;
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
