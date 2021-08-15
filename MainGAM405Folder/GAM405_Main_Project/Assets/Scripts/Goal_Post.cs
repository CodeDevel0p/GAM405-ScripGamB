using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Goal_Post : MonoBehaviour
{

    public string levelClearScene = "Player_Win_Scene";
    protected Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnCollisionEnter(Collision collision)
    {

        //Game is won when the player collides with the flagpole.
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("The game has been won!");
            SceneManager.LoadScene("Player_Win_Scene");
        }
    }
}
