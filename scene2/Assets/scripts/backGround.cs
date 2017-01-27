using UnityEngine;
using System.Collections;

public class backGround : MonoBehaviour {
	public AudioClip backgroundSound;
	private AudioSource backgroundSource;
	// Use this for initialization
	void Start () {
		backgroundSource = gameObject.AddComponent<AudioSource> ();
		backgroundSource.clip = backgroundSound;
		backgroundSource.volume = 0.2f;
		backgroundSource.Play ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
