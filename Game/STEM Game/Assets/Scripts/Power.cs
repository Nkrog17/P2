using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour {

    

    private void OnMouseDown()
    {
        FindObjectOfType<SoundPlayer>().playSound("Click");
        if (opAdTrappenBehaviour.light != true)
        opAdTrappenBehaviour.light = true;
    }
}
