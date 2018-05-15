using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kam : MonoBehaviour {

	static public bool kamClicked;
	public GameObject kamobject;
    public GameObject vis;

	public GameObject backicon;
	public GameObject keyicon;

	// Use this for initialization
	void Start () {
		kamClicked = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		kamClicked = true;
		backicon.SetActive (false);
		keyicon.SetActive (true);
		kamobject.SetActive (false);
        TextManager.An = 1;
        vis.SetActive(true);
	}
}
