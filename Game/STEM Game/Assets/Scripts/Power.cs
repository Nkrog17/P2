using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour {

    

    private void OnMouseDown()
    {
        if (opAdTrappenBehaviour.light != true)
        opAdTrappenBehaviour.light = true;
    }
}
