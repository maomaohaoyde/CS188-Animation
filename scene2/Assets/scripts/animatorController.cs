using UnityEngine;
using System.Collections;

public class animatorController : MonoBehaviour {

	public GameObject america;
	public GameObject japan;
	public GameObject germany;
	public GameObject italy;
	private Animator amAni;
	private Animator jaAni;
	private Animator geAni;
	private Animator itAni;
	// Use this for initialization
	void Start () {
		amAni = america.GetComponent<Animator> ();
		jaAni = japan.GetComponent<Animator> ();
		geAni = germany.GetComponent<Animator> ();
		itAni = italy.GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		if (germany.transform.position.x - america.transform.position.x <= 10) {
			amAni.SetBool ("met", true);
			geAni.SetBool ("met", true);
			jaAni.SetBool ("met", true);
			itAni.SetBool ("met", true);
		}
	}
}
