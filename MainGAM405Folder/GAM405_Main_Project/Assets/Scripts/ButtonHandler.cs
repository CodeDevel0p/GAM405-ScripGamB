using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{

    public string mainGameScene = "Game_Level_1";
    public string trainingScene = "Testing_Environment_Scene";

    public AudioClip buttonSelect;
    public AudioClip musicPlay;
    protected AudioSource source;
    public Canvas controlCanvas;


    // Start is called before the first frame update
    void Start()
    {
        controlCanvas.enabled = false;
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ClickStart()
    {
        source.PlayOneShot(buttonSelect);
        Debug.Log("Start the Game");
        SceneManager.LoadScene(mainGameScene);

    }

    public void ClickControls()
    {
        source.PlayOneShot(buttonSelect);
        Debug.Log("Loads up the controls");
        controlCanvas.enabled = true;

    }

    public void ClickTraining()
    {
        source.PlayOneShot(buttonSelect);
        Debug.Log("Go to Training Stage");
        SceneManager.LoadScene(trainingScene);
      
    }

    public void ClickExit()
    {
        source.PlayOneShot(buttonSelect);
        return;
 
    }

    public void MusicPlay()
    {
        musicPlay = GetComponent<AudioClip>();
    }

}
