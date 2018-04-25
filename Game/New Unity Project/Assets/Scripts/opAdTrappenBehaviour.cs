using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class opAdTrappenBehaviour : MonoBehaviour {


    public int SceneNum;
    public int activeScene;

    private void OnMouseDown()
    {
        activeScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(SceneNum);
    }
}
