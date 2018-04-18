using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneBehaviour : MonoBehaviour {

    public ClickableObjects Object;


    void behaviour() {
        
        if (GetComponent<ClickableObjects>().OnMouseDown()) {

        }
    }
}
