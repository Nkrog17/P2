using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonWithSceneIndexAsAug : MonoBehaviour {

	public bool SceneSwitch = false;
	public string SceneName;

    public void OnMouseDown() {
		if (TextManager.conversationEnd) {

			if (SceneSwitch)
				TextManager.An = 1;
			
			Initiate.Fade(SceneName, Color.black, 2.0f); 

		}
    }
}
