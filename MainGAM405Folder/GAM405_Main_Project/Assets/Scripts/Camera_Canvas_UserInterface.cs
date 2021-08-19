using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Camera_Canvas_UserInterface : MonoBehaviour
{          
    public Text playerLives, lifeCount;
    public Text playerHealth, healthValue;
    public Text playerMovespeed, moveValue;
    public Text playerJumpHeight, jumpValue;
    public Text playerThrowDistance, throwValue;
    public Text remainingTimeLeft, timerValue;
    public Canvas playerCanvasUI;
    public string gameOverScene = "Player_Lose_Scene";

    public Transform target;
    public Vector3 offsetVal;
    public float speedCamera = 0.125f;
    public float timer = 180.0f;

    public AudioClip gameMusic;
    public AudioSource sourceMusic;


    void LateUpdate()
    {
        transform.position = target.position + offsetVal;
    }

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Player>();
        sourceMusic = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            timer = 0;
        }
        DisplayTimeLeft(timer);
    }

    public void PlayMusic()
    {
        gameMusic = GetComponent<AudioClip>();
        sourceMusic.Play();
    }

    public void DisplayTimeLeft(float timeRemaining)
    {
        //Game is over when the timer reaches 0
        if (timer < 0)
        {
            timer = 0;
            SceneManager.LoadScene(gameOverScene);
        }

        float minutes = Mathf.FloorToInt(timer / 60);
        float seconds = Mathf.FloorToInt(timer % 60);

        
        timerValue.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void DisplayPlayerStats()
    {

    }
}
