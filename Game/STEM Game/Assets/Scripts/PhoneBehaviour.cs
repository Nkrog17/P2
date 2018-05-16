using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhoneBehaviour : MonoBehaviour {

    public GameObject change;
	public AudioSource ring;

	void Start(){
		ring.Play();		
	}


    void OnMouseDown()
    {
        FindObjectOfType<click>().playClick();
        change.GetComponent<TextsMethods>().turnOnObject();
        //change.SetActive(true);
        Destroy(ring);
    }
}
