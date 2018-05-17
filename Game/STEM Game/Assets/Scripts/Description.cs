using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Description : MonoBehaviour {

	public string beskrivelse;
	public GameObject descriptionbox;
	public int duration = 150;
	bool showing = false;
	Text textbox;
	int timer;

	// Use this for initialization
	void Start () {
		descriptionbox.SetActive (false);
		textbox = descriptionbox.GetComponentInChildren<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (showing) {
			timer += 1;
			if (timer >= duration){
				showing = false;
				timer = 0;
				descriptionbox.SetActive (false);
			}
		}
	}

	void OnMouseDown (){
		if (TextManager.conversationEnd) {
            FindObjectOfType<click>().playClick();
            timer = 0;
			descriptionbox.SetActive (true);
			textbox.text = beskrivelse;
			showing = true;
		}
	}
}
