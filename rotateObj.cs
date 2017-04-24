using UnityEngine;
using System.Collections;

public class rotateObj : MonoBehaviour {

	public float speed = 5f;
	public int value;
	void Update () {
		gameObject.transform.Rotate (0, speed, 0);
	}
	void onTriggerEnter(){
		//Call collect function


		//Play sound
		//Create a local variable for the audio source

		AudioSource source = GetComponent<AudioSource> ();
		source.Play ();

	}
	
}
