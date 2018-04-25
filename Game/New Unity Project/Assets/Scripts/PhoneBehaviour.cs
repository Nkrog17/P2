using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhoneBehaviour : MonoBehaviour {

    public GameObject change;


    void OnMouseDown()
    {
            change.GetComponent<TextsMethods>().turnOnObject();
            //change.SetActive(true);
    }
}
