using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class correctSound : MonoBehaviour {

    public AudioClip correctSoundfile;
    public AudioSource clipSource;
    



    void Start()
    {
        clipSource.clip = correctSoundfile;
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayTheSound()
    {
        Debug.Log("now!");
        clipSource.Play();
    }

    
}
