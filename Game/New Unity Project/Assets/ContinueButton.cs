using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContinueButton : MonoBehaviour {

    public GameObject click;
    public GameObject button;
    public Slider radiusSlider;
    public Slider speedSlider;
    public Slider timeSlider;

	// Use this for initialization
	void Start () {
        button.SetActive(false);
	}

    // Update is called once per frame
    void Update() {

	}
}