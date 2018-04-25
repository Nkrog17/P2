using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextManager : MonoBehaviour {

    public TextsMethods txt;
    public GameObject vis;
    public bool firstAn = true;

    public object Texts { get; internal set; }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Scene 1: PoliceStation
        if (SceneManager.GetActiveScene().buildIndex == 1) {
            if (firstAn == true)
            {
                txt.setText1("Answer1");
                txt.setText2("Answer2");
                txt.setText3("Answer3");
                firstAn = false;
            }

            txt.setQuestion("Question");

            if (txtBehavior.button1)
            {
                Debug.Log("Button1Clicked 1");
                txtBehavior.button1 = false;
            }
            else if (txtBehavior.button2)
            {
                Debug.Log("Button1Clicked 2");
                txtBehavior.button2 = false;
            }
            else if (txtBehavior.button3) {
                Debug.Log("Button1Clicked 3");
                txt.setText3("nej!");
                txtBehavior.button3 = false;
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
