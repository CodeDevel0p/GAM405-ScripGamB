using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class BatteryVersions : Battery
{
    public GameObject redBattery, blueBattery, greenBattery, yellowBattery;
    

    void Start()
    {
        GetComponent<Player>();
        
     }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("The player has absorbed a power up!");
            source.Play();
            Destroy(this.gameObject);

            //Here I determine what stats to update if the player collides with a battery of a certain type.
            if (redBattery) { 
                
            }

        }
    }
}