using UnityEngine.Audio;
using UnityEngine;

public class click : MonoBehaviour {

    public AudioClip clip;

    public AudioSource source;


	// Use this for initialization
	void Awake () {
        source.clip = clip;
	}
	
	// Update is called once per frame
	public void playClick()
    {
        source.Play();
    }
}
