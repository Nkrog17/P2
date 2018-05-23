﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class opAdTrappenBehaviour : MonoBehaviour {

   static  public bool light = false; 

    public int SceneNumLight;
    public int SceneNumNoLight;
    public int activeScene;

    private void OnMouseUpAsButton()
    {
        if (TextManager.conversationEnd)
        {
            FindObjectOfType<SoundPlayer>().playSound("Click");
            activeScene = SceneManager.GetActiveScene().buildIndex;
            if (opAdTrappenBehaviour.light)
                SceneManager.LoadScene(SceneNumLight);

            else
                SceneManager.LoadScene(SceneNumNoLight);
        }
    }

    
}
