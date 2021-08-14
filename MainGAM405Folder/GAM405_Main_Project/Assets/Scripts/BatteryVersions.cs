using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class BatteryVersions : Battery
{


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("The player has absorbed a power up!");
            source.Play();
            Destroy(this.gameObject);

        }
    }
}