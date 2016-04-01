using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private Rigidbody2D _myRigidbody;
	public float speed;

	// Use this for initialization
	void Start () {
		_myRigidbody= this.GetComponent<Rigidbody2D>();
	
	}
	
	// Update is called once per frame
	void Update () {
		float move = Input.GetAxis("Horizontal");
		_myRigidbody.velocity = new Vector2 (move * speed, _myRigidbody.velocity.y);
	
	}
}
