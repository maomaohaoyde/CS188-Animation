using UnityEngine;
using System.Collections;

public class Sound : MonoBehaviour {

	public AudioClip backgroundSound;
	private AudioSource backgroundSource;
	// Use this for initialization
	void Start () {
		backgroundSource = gameObject.AddComponent<AudioSource> ();
		backgroundSource.clip = backgroundSound;
		backgroundSource.volume = 0.05f;
		backgroundSource.Play ();
	}
}
