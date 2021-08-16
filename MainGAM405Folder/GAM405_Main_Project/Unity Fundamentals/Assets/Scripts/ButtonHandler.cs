using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public UnityEngine.UI.Text textField;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickHandlerNoParams()
    {
        Debug.Log("Click Handler");
    }

    public void ClickHandlerParams(int number)
    {
        Debug.Log("Value was: " + number);
    }

    public void ClickHandler(string NewText)
    {
        textField.text = NewText;
    }
}
