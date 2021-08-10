using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; //Include events with using UnityEngine.Events


[System.Serializable]
public class UnityEventSingleParam : UnityEvent<int> { } //If you want to use a specific event parameter, then you'll need to set up a class for this event/
public class MainController : MonoBehaviour
{

    public UnityEvent Event1; //A standard UnityEvent with no other things necessary for invocation
    public UnityEventSingleParam Event2; //A UnityEvent that requires an integer or parameter passed in the invocation

    //For C# Events
    public delegate void SimpleEventHandler(int value); //Defines the parameters and how we create the delegate. Defines the structure for the event and the variable it listens for.
    public delegate void BasicEvent(float nextVal); //Format of events, listeners will hear the parameters.

    public event BasicEvent myEvent; //The actual event.
    public SimpleEventHandler Event3; //Creates a variable that holds events

    // Start is called before the first frame update
    void Start()
    {
        // += Adds the display function as a listener for Event3
        // -= handles removing the listener
        Event3 += DisplayCSharpEvent;
        myEvent += OutputTime;
        myEvent.Invoke(20);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Event1.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Event2.Invoke(10);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Event3(20);
        }
    }

    public void DisplayCSharpEvent(int value)
    {
        Debug.Log("Displayed C# Value = :" + value);
    }

    public void OutputTime(float time)
    {
        Debug.Log(time);
    }
}
