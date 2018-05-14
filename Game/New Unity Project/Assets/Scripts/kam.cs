using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kam : MonoBehaviour {

	static public bool kamClicked;

    public GameObject vis;

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
        print(kamClicked);
        vis.SetActive(true);
	}
}
