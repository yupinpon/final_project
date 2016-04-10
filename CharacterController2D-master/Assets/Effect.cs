using UnityEngine;
using System.Collections;

public class Effect : MonoBehaviour {

	public GameObject explosion;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void onTriggerEnter (Collider2D other) {
		if (other.tag == "Player") {
			Instantiate (explosion, transform.position, transform.rotation);

			//Destroy (gameObject);
	
	}
}
}
