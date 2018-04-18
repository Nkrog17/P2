using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonWithSceneIndexAsAug : MonoBehaviour {


    public int SceneNum;
    public int activeScene;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void buttonClicked() {

        activeScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(SceneNum);
    }
}
