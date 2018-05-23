using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HouseInfo : MonoBehaviour {

    public GameObject info;
    public GameObject houseText;

    void OnMouseDown()
    {
        FindObjectOfType<SoundPlayer>().playSound("Click");
        info.SetActive(true);
        houseText.SetActive(true);
    }

    void OnMouseExit()
    {
        info.SetActive(false);
        houseText.SetActive(false);
    }
    // Use this for initialization
    void Start () {
        info.SetActive(false);
        houseText.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
