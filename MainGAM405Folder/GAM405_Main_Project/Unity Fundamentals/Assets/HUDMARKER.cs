using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HUDMARKER : MonoBehaviour
{
    public RectTransform MarkerInUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Calculates screen position for marker
        Vector3 screenPosition = Camera.main.WorldToScreenPoint(transform.position);

        //Clamps a position to screen bounds.
        Bounds screenBounds = new Bounds(new Vector3(Screen.width / 2f, Screen.height / 2f, 0f), (new Vector3(Screen.width, Screen.height, 0f)));
        screenPosition = screenBounds.ClosestPoint(screenPosition);

        //Set the marker locatino
        MarkerInUI.position = screenPosition;
    }
}
