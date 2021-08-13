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

    public AudioClip buttonSelect;
    public AudioClip musicPlay;
    protected AudioSource source;


    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ClickStart()
    {
        OnPlay();
        Debug.Log("Start the Game");
        SceneManager.LoadScene(mainGameScene);

    }

    public void ClickControls()
    {
        OnPlay();
        Debug.Log("Loads up the controls");

    }

    public void ClickTraining()
    {
        OnPlay();
        Debug.Log("Go to Training Stage");
        SceneManager.LoadScene(trainingScene);
      
    }

    public void ClickExit()
    {
        OnPlay();
        return;
 
    }

    public void MusicPlay()
    {
        musicPlay = GetComponent<AudioClip>();
    }

    public void OnPlay()
    {
        buttonSelect = GetComponent<AudioClip>();
        source.PlayOneShot(buttonSelect);
    }
   
}
