using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private Rigidbody2D _myRigidbody;
	private Animator _anim;
	public float speed;

	// Use this for initialization
	void Start () {
		_myRigidbody= this.GetComponent<Rigidbody2D>();
		_anim = GetComponent<Animator> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		float move = Input.GetAxis("Horizontal");
		_anim.SetFloat ("Speed", move);
		_myRigidbody.velocity = new Vector2 (move * speed, _myRigidbody.velocity.y);
	
	}
}
