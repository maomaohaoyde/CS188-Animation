using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cameraController : MonoBehaviour {
	public Camera[] cameras;
	private int currentCameraIndex;
	public Vector3 to0Position;
	public float to0Speed;

	public GameObject pearl;
	private Animator pearlAnimator;
	private int dialogueIndex;

	private float timer;

	public AudioClip[] dialogueSound;
	private AudioSource dialogueSource;
	// Use this for initialization
	void Start () {
		currentCameraIndex = 0;

		//Turn all cameras off, except the first default one
		for (int i=1; i<cameras.Length; i++) 
		{
			cameras[i].gameObject.SetActive(false);
		}

		dialogueSource = gameObject.AddComponent<AudioSource> ();
		dialogueSource.clip = dialogueSound [0];
		dialogueSource.Play ();
		//If any cameras were added to the controller, enable the first one
			cameras [0].gameObject.SetActive (true);

		dialogueIndex=1;
	
		timer = 0;
		pearlAnimator = pearl.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (!dialogueSource.isPlaying && dialogueIndex<dialogueSound.Length) {

			dialogueSource.clip=dialogueSound[dialogueIndex];
			dialogueIndex++;
			dialogueSource.Play ();
			switch (currentCameraIndex) {
			case 0:
					setNextCam (2);
				break;
			case 1:
				setNextCam (2);
				break;
			case 2:
				setNextCam (1);
				break;
			}

		}
		if (dialogueIndex > dialogueSound.Length)
			Application.Quit ();

	}
	public void setNextCam(int index)
	{
		cameras [currentCameraIndex].gameObject.SetActive (false);
		currentCameraIndex = index;
		cameras [index].gameObject.SetActive (true);
	}

	bool MoveTo(int index,Vector3 targetPos, float speed)
	{
		float step = speed * Time.deltaTime;
		cameras[index].gameObject.transform.position = Vector3.MoveTowards(cameras[index].gameObject.transform.position, targetPos, step);

		return (cameras[index].gameObject.transform.position == targetPos);
	}
}
