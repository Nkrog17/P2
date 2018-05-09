using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadiusScale : MonoBehaviour {

    public float scale;
    public Slider radius;

    public Transform target;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        scale = radius.value/20;
       // Debug.Log(scale);


        target.localScale = new Vector3(scale, scale, scale);
        

    }
}
