using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacesController : MonoBehaviour {

	private AudioSource source;
	[SerializeField] private AudioClip placesSound;

	void OnTriggerEnter (Collider col) {
		Debug.Log ("You've entered " + gameObject.name + " place.");
		source = col.GetComponent<AudioSource> ();
		source.PlayOneShot (placesSound, 1f);
		Destroy (gameObject);
	}
}
