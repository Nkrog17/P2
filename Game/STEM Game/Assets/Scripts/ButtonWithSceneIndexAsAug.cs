﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonWithSceneIndexAsAug : MonoBehaviour {

	public bool SceneSwitch = false;
	public bool Fade;
	public string SceneName;

    public void OnMouseUpAsButton() {
		if (TextManager.conversationEnd) {

            FindObjectOfType<SoundPlayer>().playSound("Click");

            if (SceneSwitch)
				TextManager.An = 1;
			if (Fade) {
				Initiate.Fade (SceneName, Color.black, 2.0f);
			} else {
				SceneManager.LoadScene (SceneName);
			}

		}
    }
}
