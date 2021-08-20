using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;


[System.Serializable]

public class EventControllerListener : MonoBehaviour
{
    public Text playerLives, playerHealth, playerMoveSpeed, playerJumpHeight, playerBlastOff;
    public Text remainingTimeLeft, timerValue;
    public Canvas playerCanvasUI;

    public string returnMenuPress = "MainMenuScene";
    public string gameOverScene = "Player_Lose_Scene";


    //This event is supposed to track the player's stats and update them to the User Interface display
    public UnityEvent Event1Stats;
    public UnityEvent Event2UIUpdate;

    public delegate void GameOverEvent(string gameOverScene);
    public event GameOverEvent event5;

    //This event is for the collision between the player and the batteries
    public UnityEvent Event3;

    //PlayerHealth is lost and game over scenes.
    public UnityEvent Event4;

    // Start is called before the first frame update
    void Start()
    {
        Event1Stats.Invoke();
        GetComponent<Enemy>();
        GetComponent<Player>();
        event5.Invoke(gameOverScene);
        //event5.Invoke(gameOverScene);
    }

    // Update is called once per frame
    void Update()
    {
        SceneManagerEvent();

        //"Remaining Lives: " + PlayerLives.ToString() + GetComponent<Player>().lifeCount;
    }

    public void SceneManagerEvent()
    {
        //Return to the main menu and reset progress
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(returnMenuPress);
        }

      if (GetComponent<Player>().health <= 0)
        {
           // event5.Invoke(gameOverScene);
            SceneManager.LoadScene(gameOverScene);
        }

        
    }

}

