using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Listener : MonoBehaviour
{
    public Text Test1String, Test2String, Test3String, Test4String;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateTextOverTime()
    {
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {

            Test1String.text = ("A");
        }
    }
}
