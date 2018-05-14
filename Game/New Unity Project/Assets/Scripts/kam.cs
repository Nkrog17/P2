using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kam : MonoBehaviour {

	static public bool kamClicked;

	// Use this for initialization
	void Start () {
		kamClicked = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		kamClicked = true;
		gameObject.SetActive (false);
	}
}
