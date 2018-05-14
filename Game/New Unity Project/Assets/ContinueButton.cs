using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContinueButton : MonoBehaviour {

    public GameObject click;
    //public GameObject house;
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
/*
        if (radiusSlider.value > 24.77 && radiusSlider.value < 25.27)
            if (speedSlider.value > 58 && speedSlider.value < 62)
                if (timeSlider.value > 4.5 && timeSlider.value < 5.5)
                   if (click.activeSelf == true) {
                    button.SetActive(true);
                }
                else
                {
                    button.SetActive(false);
                }*/
	}
}