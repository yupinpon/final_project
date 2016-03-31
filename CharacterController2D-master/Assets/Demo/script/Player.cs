using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private Rigidbody2D _myRigidbody;
	private Animator _anim;
	private bool _facingRight = true;
	public float speed;

	// Use this for initialization
	void Start () {
		_myRigidbody= this.GetComponent<Rigidbody2D>();
		_anim = GetComponent<Animator> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		float move = Input.GetAxis("Horizontal");
		_anim.SetFloat ("Speed", Mathf.Abs( move));
		_myRigidbody.velocity = new Vector2 (move * speed, _myRigidbody.velocity.y);
	
		if (_facingRight == true && move < 0)
		{
			_facingRight = false;
			transform.rotation = Quaternion.Euler (transform.rotation.x, 180, transform.rotation.z);
		}else if (_facingRight ==false && move> 0)
			{
				_facingRight = true;
				transform.rotation = Quaternion.Euler(transform.rotation.x ,0 , transform.rotation.z);
			}
			if (Input.GetKeyDown(KeyCode.Space))
			{
				_anim.SetBool("run",true);
			_myRigidbody.velocity = new Vector2(_myRigidbody.velocity.x,10);

			}
		}
	}

