using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{

    public string mainGameScene = "Game_Level_1";
    public string controlsScene;
    public string trainingScene = "Testing_Environment_Scene";


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ClickStart()
    {
        Debug.Log("Start the Game");
        SceneManager.LoadScene(mainGameScene);
    }

    public void ClickControls()
    {
        Debug.Log("Loads up the controls");
    }

    public void ClickTraining()
    {
        Debug.Log("Go to Training Stage");
        SceneManager.LoadScene(trainingScene);
    }

    public void ClickExit()
    {
        return;
    }
}
