using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGameButtons : MonoBehaviour
{
    public string returnToLevel = "Game_Level_1";
    public string mainMenuReturn = "MainMenuScene";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartLevel()
    {
        Debug.Log("The level has restarted");
        SceneManager.LoadScene("Game_Level_1");
    }

    public void MenuReturn()
    {
        Debug.Log("The level has restarted");
        SceneManager.LoadScene("MainMenuScene");
    }
}
