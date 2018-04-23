using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextManager : MonoBehaviour {

    public Texts txt;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Scene 1: PoliceStation
        if (SceneManager.GetActiveScene().buildIndex == 1) {
            txt.setText1("Answer1");
            txt.setText2("Answer2");
            txt.setText3("Answer3");

            txt.setQuestion("Question");

            if (Input.GetMouseButtonDown(0))
            {
                txt.turnOffObject();
            }
            if (Input.GetMouseButtonDown(1))
            {
                txt.turnOnObject();
            }
        }
        //Scene 2: GrenevsIntrance
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            txt.setText1("Answer1");
            txt.setText2("Answer2");
            txt.setText3("Answer3");

            txt.setQuestion("Question");
        }
        //Scene 3
        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            txt.setText1("Answer1");
            txt.setText2("Answer2");
            txt.setText3("Answer3");

            txt.setQuestion("Question");
        }
        //Scene 4
        else if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            txt.setText1("Answer1");
            txt.setText2("Answer2");
            txt.setText3("Answer3");

            txt.setQuestion("Question");
        }
    }
}
