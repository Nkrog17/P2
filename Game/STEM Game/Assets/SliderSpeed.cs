using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderSpeed : MonoBehaviour {

    public Text sliderValue;

	// Use this for initialization
	void Start () {
        sliderValue = GetComponent<Text>();
	}
	
    public void TextUpdate (float value)
    {
        sliderValue.text = ""+Mathf.RoundToInt(value);
    }
}
