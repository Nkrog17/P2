using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadiusSliderSpeed : MonoBehaviour
{
    public Text sliderValue;

    void Start()
    {
        sliderValue = GetComponent<Text>();
    }

    public void TextUpdate(float value)
    {
        value = value/5 * 10;
        value = Mathf.RoundToInt(value);
        value = value / 10;
        sliderValue.text = ""+value;
    }
}