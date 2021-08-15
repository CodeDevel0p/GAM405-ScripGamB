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
            float addValue = throwDistanceUp;
        }

        if (bluBattery == BatteryType.Blue)
        {
            float addValue = moveSpeedUp;
        }
        
        if (grnBattery == BatteryType.Green)
        {
            float addValue = healthUp;
        }

        if (ylwBattery == BatteryType.Yellow)
        {
            float addValue = jumpHeightUp;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && this.gameObject == redBatteryOBJ)
        {
            Debug.Log("The player has absorbed a RED power up! Blast Distance Up!");
            source.Play();
            Destroy(this);

        }

        if (other.CompareTag("Player") && this.gameObject == bluBatteryOBJ)
        {
            Debug.Log("The player has absorbed a BLUE power up! Move Speed Up!");
            source.Play();
            Destroy(this);

        }

        if (other.CompareTag("Player") && this.gameObject == grnBatteryOBJ)
        {
            Debug.Log("The player has absorbed a GREEN power up! Health Restored");
            source.Play();
            Destroy(this);

        }

        if (other.CompareTag("Player") && this.gameObject == ylwBatteryOBJ)
        {
            Debug.Log("The player has absorbed a YELLOW power up! Jump Height Up!");
            source.Play();
            Destroy(this);

        }
    }
}
