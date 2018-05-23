using UnityEngine.Audio;
using UnityEngine;

public class SoundPlayer : MonoBehaviour {

    public Sounds[] sounds;

    private bool created;


	// Use this for initialization
	void Awake () {
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
        }
        
        foreach (Sounds i in sounds)
        {
            i.audioSource = gameObject.AddComponent<AudioSource>();
            i.audioSource.clip = i.Clip;
        }
        
	}
	
	// Update is called once per frame
	public void playSound(string name)
    {
        foreach (Sounds i in sounds)
        {
            if (i.name == name)
            {
                i.audioSource.Play();
            }
        }
    }
}
