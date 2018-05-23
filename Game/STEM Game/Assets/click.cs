using UnityEngine.Audio;
using UnityEngine;

public class click : MonoBehaviour {

    public AudioClip clip;

    public AudioSource source;

    private bool created;


	// Use this for initialization
	void Awake () {
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
        }
        source.clip = clip;
        
	}
	
	// Update is called once per frame
	public void playClick()
    {
        source.Play();
    }
}
