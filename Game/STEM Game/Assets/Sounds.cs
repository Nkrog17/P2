using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sounds {

    public string name;

    public AudioClip Clip;

	[HideInInspector]
    public AudioSource audioSource;
	
}
