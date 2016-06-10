using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {
			void OnTriggerEnter2D (Collider2D other){
		if (other.tag == "Player") {
			
		}
		if (other.tag == "meat") {
			Destroy (other.gameObject);
		}
		if (other.tag == "grass") {
			Destroy (other.gameObject);
		}
		if (other.tag == "Score") {
			Destroy (other.gameObject);
		}
		}
	}
