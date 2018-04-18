using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class opAdTrappenBehaviour : MonoBehaviour {


    public int SceneNum;
    public int activeScene;

    void behaviour()
    {

        if (GetComponent<ClickableObjects>().OnMouseDown())
        {
            activeScene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(SceneNum);
        }
    }
}
