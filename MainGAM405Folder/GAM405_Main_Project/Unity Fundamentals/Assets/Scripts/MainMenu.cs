using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject toggleButton;
    public GameObject loadButton;
    /*
    // Start is called before the first frame update
    void Start()
    {
        LoadTheme();
    }

    public void SetTheme()
    {
        int newTheme = 1;

        //Get our current theme from playerPrefs
        if (PlayerPrefs.HasKey("Theme"))
        {
             newTheme = PlayerPrefs.GetInt("Theme") == 0 ? 1 : 0;

           //theme = theme == 0 ? 1 : 0;
        }
        PlayerPrefs.SetInt("Theme", newTheme);
        //Set it to the *other*
        //load theme
    }

    public void StartGame()
    {
        //Load our game level.
    }

    public void LoadTheme()
    {
        //Set our menu theming on actual elements
        toggleButton.GetComponent<Image>().color = Color.white;
    }
    */
}
