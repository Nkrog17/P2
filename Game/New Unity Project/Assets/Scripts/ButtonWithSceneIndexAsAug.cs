﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonWithSceneIndexAsAug : MonoBehaviour {


    public int SceneNum;
    public int activeScene;

    public void OnMouseDown() {

        if (TextManager.conversationEnd == true)
        {
            activeScene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(SceneNum);
        }
    }   
}
