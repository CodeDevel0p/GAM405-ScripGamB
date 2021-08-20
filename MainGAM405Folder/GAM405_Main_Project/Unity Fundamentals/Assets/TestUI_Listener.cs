using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class TestUI_Listener : MonoBehaviour
{
    public Text BoxesHitText;
   
    public UnityEvent unityEvent;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TestControls>();
        int boxesUICount = BoxesHitText.text.Length;
    }

    // Update is called once per frame
    void Update()
    {
        TestControls testControls = GetComponent<TestControls>();
        unityEvent.Invoke();
        
    }


}
