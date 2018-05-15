using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vundet : MonoBehaviour {

	public GameObject txt;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (TextManager.conversationEnd) {
			txt.SetActive (true);
		} else {
			txt.SetActive (false);
		}
	}
}
