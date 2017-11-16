using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {

	public GameObject objToDestroy; 
	public GameObject effect; 
	public AudioClip clip;  
	public int scoreValue; 

	void Start(){
	}

	void OnTriggerEnter(Collider other) { 

		Debug.Log("Nurrrr");
		if (other.gameObject.CompareTag("Player")) {
			this.gameObject.SetActive (false); 
			GameObject obj = new GameObject ();
			AudioSource src = obj.AddComponent<AudioSource> ();
			src.clip = clip;
			src.Play ();
			Destroy (obj, clip.length);
//			Character_Controller.AddScore (scoreValue); 
		}


	} 

}
