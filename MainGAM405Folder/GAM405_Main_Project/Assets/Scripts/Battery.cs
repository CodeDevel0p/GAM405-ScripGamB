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

    public BatteryType batteryType;
    public GameObject batteryModel;
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
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>())
        {
            switch (batteryType)
            {
                case BatteryType.Red:
                    Debug.Log("The player has absorbed a RED power up! Blast Distance Up!");
                    
                    Destroy(this.gameObject);
                    break;
                    
                case BatteryType.Blue:
                    Debug.Log("The player has absorbed a BLUE power up! Move Speed Up!");
                    Destroy(this.gameObject);
                    break;

                case BatteryType.Green:
                    Debug.Log("The player has absorbed a GREEN power up! Health Up!");
                    Destroy(this.gameObject);
                    break;

                case BatteryType.Yellow:
                    Debug.Log("The player has absorbed a YELLOW power up! Jump Height Up!");
                    Destroy(this.gameObject);
                    break;
            }
        }

    }
}
