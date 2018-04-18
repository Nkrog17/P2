using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickableObjects : MonoBehaviour {

    public bool OnMouseDown(){
        if (tag == "Clickable")
        {
            Debug.Log("clicked a clickable object");
            return true;
        }
        else {
            return false;
        }
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
