using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySettingsTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //It's always good practice for when creating a default value of some kind, you use PlayerPrefs.Save() so that it stores and remembers that data/value.
        //Remember - PlayerPrefs is designed to store small, simple data. It's not designed for trying to store a large save file data.
        //Use a domain-style typesetting. Always make sure to use .Save() once a value is set up.
        PlayerPrefs.SetInt("Settings.Volume", 25);
        PlayerPrefs.Save();

        int volumeLevel = PlayerPrefs.GetInt("Settings.Volume", 50);
        Debug.Log(volumeLevel);

           //DeleteAll() will delete all stored keys. DeleteKey will just delete a single key that is being targeted.
           //PlayerPrefs.DeleteAll();

       if (PlayerPrefs.HasKey("Settings.MusicVolume"))
        {
            Debug.LogWarning("Key not Present");
        }

        if (PlayerPrefs.HasKey("Settings.Volume"))
        {
            Debug.LogWarning("Setting.Volume Present");
        }

        bool boolValueToSave = true;
        PlayerPrefs.SetInt("Settings.BoolValue", boolValueToSave ? 1 : 0);

        bool boolValueLoaded = PlayerPrefs.GetInt("Settings.BoolValue") == 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
