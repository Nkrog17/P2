using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultCalculator : MonoBehaviour {

    public int speedValue;
    public int timeValue;
    public Slider timeSlider;
    public Slider speedSlider;
    public Text result;

	// Use this for initialization
	void Start () {
        result = GetComponent<Text>();
	}
	
	// Update is called once per frame
    void Update()
    {
        result.text = "" + Mathf.RoundToInt(speedSlider.value * (timeSlider.value / 60));
    }
}
