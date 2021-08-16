using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioButtonScript : MonoBehaviour
{
    public AudioClip[] Clips;

    public AudioSource Source2;
    protected AudioSource Source;

    // Start is called before the first frame update
    void Start()
    {
        Source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPlay()
    {
        //Useful error if detects no clips present/
        if (Clips.Length == 0)
        {
            Debug.LogError("No clips set up");
            return;
        }

        //Pick a random clip
        AudioClip selectedClip = Clips[Random.Range(0, Clips.Length)];

        /*
         * We can apply effects in the code.
        Source.volume = Random.Range(0.9f, 1.1f);
        Source.pitch = Random.Range(0.9f, 1.1f);
        */
        Source.PlayOneShot(selectedClip);
    }

    public void PlaySound()
    {
        AudioClip clipToPlay = Clips[Random.Range(0, Clips.Length)];
        Source2.PlayOneShot(clipToPlay);

    }
}
