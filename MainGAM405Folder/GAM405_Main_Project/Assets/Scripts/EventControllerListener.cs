using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;


[System.Serializable]

public class EventControllerListener : MonoBehaviour
{

    public string returnMenuPress = "MainMenuScene";
    
    

    //This event is supposed to track the player's stats and update them to the User Interface display
    public UnityEvent Event1Stats;
    public UnityEvent Event2UIUpdate;

    //This event is for the collision between the player and the batteries
    public UnityEvent Event3;

    //PlayerHealth is lost and game over scenes.
    public UnityEvent Event4;

    // Start is called before the first frame update
    void Start()
    {
        Event1Stats.Invoke();
        GetComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        SceneManagerEvent();
    }

    public void SceneManagerEvent()
    {
        //Return to the main menu and reset progress
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(returnMenuPress);
        }

        GetComponent<Player>();
       
        {

        }

        
    }
}
