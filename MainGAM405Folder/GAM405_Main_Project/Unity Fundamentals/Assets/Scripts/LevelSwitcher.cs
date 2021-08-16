using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitcher : MonoBehaviour
{
    public string SceneName;
    public string SceneAltAdditive = "Level_1_Additive";
    public string SceneName2;
    public bool Asynchronous = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Asynchronous)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                SceneManager.LoadSceneAsync(SceneName, LoadSceneMode.Single);
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                SceneManager.LoadSceneAsync(SceneAltAdditive, LoadSceneMode.Additive);
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                SceneManager.LoadSceneAsync(SceneName2, LoadSceneMode.Single);
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                SceneManager.LoadScene(SceneName, LoadSceneMode.Single);
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                SceneManager.LoadScene(SceneAltAdditive, LoadSceneMode.Additive);
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                SceneManager.LoadScene(SceneName2, LoadSceneMode.Single);
            }
        }


    }
}
