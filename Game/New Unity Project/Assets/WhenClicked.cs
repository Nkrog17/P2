using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WhenClicked : MonoBehaviour {

    public int num;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void ButtonClick ()
    {
		TextManager.An = 1;
		Initiate.Fade ("Lade", Color.black, 2.0f);       
    }
}
