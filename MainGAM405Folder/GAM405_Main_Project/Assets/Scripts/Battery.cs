using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{

    public enum BatteryType
    {
        Red,
        Blue,
        Green,
        Yellow
    }

    public GameObject redBatteryOBJ, bluBatteryOBJ, grnBatteryOBJ, ylwBatteryOBJ;
   BatteryType redBattery = BatteryType.Red;
   BatteryType bluBattery = BatteryType.Blue;
   BatteryType grnBattery = BatteryType.Green;
   BatteryType ylwBattery = BatteryType.Yellow;

    protected Rigidbody rb;

    public float throwDistanceUp = 3.0f;
    public float moveSpeedUp = 2.0f;
    public float healthUp = 3.0f;
    public float jumpHeightUp = 2.0f;
    public AudioClip PowerUp;
    public AudioSource source;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        if (redBattery == BatteryType.Red)
        {

        }

        if (bluBattery == BatteryType.Blue)
        {

        }
        
        if (grnBattery == BatteryType.Green)
        {

        }

        if (ylwBattery == BatteryType.Yellow)
        {

        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("The player has absorbed a power up!");
            source.Play();
            Destroy(this);
         
        }
    }
}
