using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlaySound : MonoBehaviour {

	public AudioClip clip;
	public float interactDelay = 0;

	void OnTriggerEnter(Collider other)
	{

		if (other.tag == "Player") {

			Invoke ("PlaySound", interactDelay);
		}
	}

	private void PlaySound()
	{
		AudioSource.PlayClipAtPoint (clip, transform.position);
	}

	void Update () {
		
	}
}
