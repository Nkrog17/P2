using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HouseAppear : MonoBehaviour {

    public float distance;
    public GameObject house;
    public Slider radius;
    
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        //print(radius.value);
        if (radius.value >= distance)
        {
            house.SetActive(true);
            //Debug.Log("true");
        }
        else
        {
            house.SetActive(false);
            //Debug.Log("false");
        }

	}
}
