using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Description : MonoBehaviour {

	public string beskrivelse;
	public GameObject descriptionbox;
	bool showing = false;
	public GameObject txt;

	// Use this for initialization
	void Start () {
		descriptionbox.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown (){
		descriptionbox.SetActive (true);
	}
}
