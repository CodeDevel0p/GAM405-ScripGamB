using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Debug.LogError("Got an extra singleton!!!");
            Destroy(this.gameObject);
        }
    }
    public void OnPlayerDamage()
    {
        print("damaged");
    }
}
