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
    public float blastOffDistance = 1.0f;
    new public float health = 6.0f;
    new public float moveSpeed = 3.0f;
    new public float jumpHeight = 3.0f;
    public int lifeCount = 4;
    protected float moveHorizontal, moveVertical, jumpUp, blastLaunch;
    private float playerVelocity = 2.5f;
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
        Debug.Log("Health = " + health + " Move Speed = " + moveSpeed + " Jump Height = " + jumpHeight + " Blast-jump Height = " + blastOffDistance);
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
            rb.AddForce(Vector3.up * launchDistance * blastOffDistance * playerVelocity, ForceMode.VelocityChange);
            playerAudio.PlayOneShot(blastOffAudio, 0.4f);
        }
        PlayerStatsTrack();

    }

    //The main stats the player loads in with at the start of the game.
    public override void InitialStats()
    {
        health = 6; moveSpeed = 3; jumpHeight = 3; throwDistance = 2;
        Debug.Log("Health = " + health + " Move Speed = " + moveSpeed + " Jump Height = " + jumpHeight + 
            " Blast-jump Height = " + blastOffDistance + "Lives Left = " + lifeCount);
    }

    //This checks the main collisions in the game.
   public void OnCollisionEnter(Collision collision)
    {
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
            playerAudio.PlayOneShot(hurtSound);
            lifeCount--;
            if (lifeCount == 0)
            {
             SceneManager.LoadScene(gameOverScene);
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Battery>();
        playerAudio.PlayOneShot(itemPickup);

        //Switch statement to determine what stats are influenced by the player picking up a certain battery.
        switch (other.GetComponent<Battery>().batteryType)
        {
            case Battery.BatteryType.Red:
                blastOffDistance++;
                Destroy(other);
                break;
            case Battery.BatteryType.Blue:
                moveSpeed += 1.5f;
                Destroy(other);
                break;
            case Battery.BatteryType.Green:
                health += 10.0f;
                Destroy(other);
                break;
            case Battery.BatteryType.Yellow:
                jumpHeight += 1.5f;
                Destroy(other);
                break;
        }

    }

    //Keep track of player's stats with this function
    public void PlayerStatsTrack ()
    {

        Debug.Log("Health = " + health + " Move Speed = " + moveSpeed + " Jump Height = " + jumpHeight +
       " Blast-jump Height = " + blastOffDistance + "Lives Left = " + lifeCount);
        if (health == 0)
        {
            Debug.Log("Game over!");
        }
    }

}
