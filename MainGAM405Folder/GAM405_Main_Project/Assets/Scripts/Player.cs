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

    public float jumpBoost = 1.5f;
    public float launchDistance = 3.0f;
    new public float health = 6.0f;
    new public float moveSpeed = 3.0f;
    new public float jumpHeight = 3.0f;
    new public float throwDistance = 1;
    public int lifeCount = 4;
    protected float moveHorizontal, moveVertical, jumpUp, blastLaunch;
    private float playerVelocity = 2.5f;
    public string returnMenuPress = "MainMenuScene";
    public string levelClearScene = "Player_Win_Scene";
    public string gameOverScene = "Player_Lose_Scene";
    protected Rigidbody rb;

    public AudioClip jumpAudio;
    public AudioClip blastOffAudio;
    public AudioClip itemPickup;
    public AudioClip hurtSound;
    public AudioSource playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
        InitialStats();
        rb = gameObject.GetComponent<Rigidbody>();
        Debug.Log("Health = " + health + " Move Speed = " + moveSpeed + " Jump Height = " + jumpHeight + " ThrowDistance = " + throwDistance);
        Debug.ClearDeveloperConsole();
    }

    // Update is called once per frame
    void Update()
    {
        //Here are the inputs based on horizontal and vertical inputs, Horizontal to move left and right, Vertical is intended to drop the player quickly down
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

        //Move forwards at a certain speed by the transform
        if (moveType == MovementType.TransformPosition)
        {
            transform.position += new Vector3((moveHorizontal * moveSpeed), 0, 0) * moveSpeed * Time.deltaTime;
        }
        //When the player jumps
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpHeight * jumpBoost, ForceMode.Impulse);
            playerAudio.PlayOneShot(jumpAudio);

        }
        //Launches the player with the jet backpack attached to them
        if (Input.GetKeyDown(KeyCode.Q))
        { 
             rb.AddForce(Vector3.up * launchDistance * playerVelocity, ForceMode.VelocityChange);
            playerAudio.PlayOneShot(blastOffAudio, 0.4f);
        }

        //Return to the main menu and reset progress
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(returnMenuPress);
        }

    }

    public void FixedUpdate()
    {

    }
    //The main stats the player loads in with at the start of the game.
    public override void InitialStats()
    {
        health = 6; moveSpeed = 3; jumpHeight = 3; throwDistance = 2;
        Debug.Log("Health = " + health + " Move Speed = " + moveSpeed + " Jump Height = " + jumpHeight + " ThrowDistance = " + throwDistance + "Lives Left = " + lifeCount);
    }

    //This checks the main collisions in the game.
    void OnCollisionEnter(Collision collision)
    {


        //Game is won when the player collides with the flagpole.
        if (collision.gameObject.CompareTag("Flagpole"))
        {
            Debug.Log("The game has been won!");
            SceneManager.LoadScene("Player_Win_Scene");
        }

        //Take damage upon colliding with the B.A.D.D.I Enemies.
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("The player has collided with the enemy!");
            playerAudio.PlayOneShot(hurtSound);
            health--;
            
            if (health == 0)
            {
                SceneManager.LoadScene(gameOverScene);
            }
        }
        if (collision.gameObject.CompareTag("Battery"))
        {
            Debug.Log("The player has collided with a battery - Gain a certain stat increase");
        }
        if (collision.gameObject.CompareTag("Clock"))
        {
            Debug.Log("The player has collided with a clock - increase the timer!");
        }
        //Get violently thrown up and away by a tosser robot enemy.
        if (collision.gameObject.CompareTag("Tosser"))
        {
            Debug.Log("I'm a chuckster!");
            rb.AddForce( (Vector3.left + Vector3.up) * (playerVelocity * 2.5f) * jumpBoost, ForceMode.Impulse);
            playerAudio.PlayOneShot(blastOffAudio, 0.1f); ;
        }
        //Lose a life and start back at the beginning if touching with a spike.
        if (collision.gameObject.CompareTag("Spikes"))
        {
            Debug.Log("OUCH!!!");
            lifeCount--;
            if (lifeCount == 0)
            {
                SceneManager.LoadScene(gameOverScene);
            }
        }
    }
    //This is for the batteries and clock pick-up items.
    void OnTriggerEnter(Collision other)
    {

    }
    
    //For the player's sound effects.
    void PlayerSFX()
    {
       
    }

    //Keep track of player's stats with this function
    public void PlayerStatsTrack ()
    {
        int playerLives, lifeCount;
        float playerHealth, healthValue;
        float playerMovespeed, moveValue;
        float playerJumpHeight, jumpValue;
        float playerThrowDistance, throwValue;
        float remainingTimeLeft, timerValue;

    Debug.Log("Health = " + health + " Move Speed = " + moveSpeed + " Jump Height = " + jumpHeight + " ThrowDistance = " + throwDistance);
    }

}
