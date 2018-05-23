using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSound : MonoBehaviour {

    public AudioClip clickClip;
    public AudioSource clickSource;

	// Use this for initialization
	void Start () {
        clickSource.clip = clickClip;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnMouseDown()
    {
        clickSource.Play();
    }
}

//bliver måske ikke brugt
