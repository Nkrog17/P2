using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextManager : MonoBehaviour {

    public TextsMethods txt;
    public GameObject vis;
    public int An = 1;

    public object Texts { get; internal set; }

    // Use this for initialization
    void Start () {
	}
		
	
	// Update is called once per frame
	void Update () {
        //Scene 1: PoliceStation
        if (SceneManager.GetActiveScene().buildIndex == 1) {
            txt.setQuestion("“MIN DATTER! Hun… hun.. Hun er væk!”");

            if (An == 1)
            {
                txt.setText1("“Væk?“");
                txt.setText2("“Rolig nu - er du helt sikker på det?”");
                txt.setText3("“Sæt lige tempoet ned - dit navn?”");
                
            }

            if (An == 2 || An == 11)
            {
                txt.setQuestion("“Ja, jeg er helt sikker! Hun er ikke på sit værelse og vinduet er åbent! Hun kunne aldrig finde på at stikke af midt om natten”");
                txt.setText1("");
                txt.setText2("“Du mener altså, at nogen skulle have brudt ind gennem vinduet og kidnappet hende? Giv mig din adresse, så kommer jeg med det samme.“");
                txt.setText3("");


            }

            if (An == 101)
            {
                txt.setQuestion("“Jamen… Du er nødt til at hjælpe!Mit navn er Christian Møller.Jeg er bange for der er sket hende noget”");
                txt.setText1("“Okay Hr. Møller. Jeg gør hvad jeg kan, for at komme så hurtigt som muligt - din adresse?”");
                txt.setText2("");
                txt.setText3("“Hvis du giver mig din adresse, så kommer jeg med det samme.”");
            }

            if (An >= 102 || An == 21 || An == 12)
            {
                txt.setQuestion("“Svanemøllen 3. Tak - tusinde tak!”");
                txt.setText1("");
                txt.setText2("");
                txt.setText3("");
            }


            if (txtBehavior.button1)
            {
                Debug.Log("Button1Clicked 1");
                txtBehavior.button1 = false;
                An++;
            }
            else if (txtBehavior.button2)
            {
                Debug.Log("Button1Clicked 2");
                txtBehavior.button2 = false;
                An = An+10;
            }
            else if (txtBehavior.button3) {
                Debug.Log("Button1Clicked 3");
                txt.setText3("nej!");
                txtBehavior.button3 = false;
                An = An+100;
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
