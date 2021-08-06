using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    protected float health, moveSpeed, jumpHeight, throwDistance;
    protected string characterType;
    public AudioSource audioData;

    public Character()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public virtual void InitialStats()
    {
        health = 5;
        moveSpeed = 5;
        jumpHeight = 5;
        throwDistance = 5;
    }
}
