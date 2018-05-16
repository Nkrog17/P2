using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HouseContinue : MonoBehaviour {

    public GameObject button;
    public GameObject click;
    public Slider radiusSlider;
    public Slider speedSlider;
    public Slider timeSlider;
    public bool active;

    // Use this for initialization
    void Start () {
        button.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (radiusSlider.value > 24.77 && radiusSlider.value < 25.27)
        {
            if (speedSlider.value > 58 && speedSlider.value < 62)
            {
                if (timeSlider.value > 4.5 && timeSlider.value < 5.5)
                {
                    active = true;
                }
            }
            else
            {
                active = false;
            }
        }
        else
        {
            active = false;
        }

    }

    private void OnMouseDown()
    {
        if (active == true)
        {
            button.SetActive(true);
        }

    }
}
