using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uWonText : MonoBehaviour {


    public GameObject distanceText;

    public bool uWon = false;


    public void WinCondition()
    {

        if (Behavoir.numberOfCollidersCorrect >= 20)
        {

            if (!uWon)
            {
                Debug.Log("U WON !!!");
                UWonTexT();
                uWon = true;
            }

        }

    }

    public void UWonTexT()
    {
        distanceText.SetActive(true);

    }

    public void whenClicked()
    {
            
        Debug.Log("now");
        TextManager.An = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
