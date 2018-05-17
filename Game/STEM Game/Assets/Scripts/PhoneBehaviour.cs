using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhoneBehaviour : MonoBehaviour {

    public GameObject change;
	public AudioSource ring;
    public GameObject keys;

	void Start(){
		ring.Play();		
	}


    void OnMouseDown()
    {
        FindObjectOfType<click>().playClick();
        change.GetComponent<TextsMethods>().turnOnObject();
        //change.SetActive(true);
        keys.SetActive(true);
        Destroy(ring);
    }
}
