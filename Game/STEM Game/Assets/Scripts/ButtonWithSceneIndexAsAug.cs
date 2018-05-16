using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonWithSceneIndexAsAug : MonoBehaviour {

	public bool SceneSwitch = false;
	public bool Fade;
	public string SceneName;

    public void OnMouseDown() {
		if (TextManager.conversationEnd) {

            FindObjectOfType<click>().playClick();

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
