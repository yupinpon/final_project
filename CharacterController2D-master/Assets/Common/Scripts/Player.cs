using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Player : MonoBehaviour {

	private Rigidbody2D _myRigidbody;
	private Animator _anim;
	private bool _facingRight = true;
	[SerializeField]
	private bool _canJump;
	public float speed;
	public Transform startPos;
	public Transform endPos;
	public LayerMask groundLayer;
	public float move;
	public bool CheckButton;

	// Use this for initialization
	void Start () {
		_myRigidbody= this.GetComponent<Rigidbody2D>();
		_anim = GetComponent<Animator> ();
	
	}
		
	
	// Update is called once per frame
	void Update () {
		
		if (CheckButton == false)
		{
			move = Input.GetAxisRaw ("Horizontal");
		}
			_anim.SetFloat ("Speed", Mathf.Abs (move));
			_myRigidbody.velocity = new Vector2 (move * speed, _myRigidbody.velocity.y);
		
	//	Debug.Log (move);
		if (_facingRight == true && move < 0)
		{
			_facingRight = false;
			transform.rotation = Quaternion.Euler (transform.rotation.x, 180, transform.rotation.z);
			}
			else if (_facingRight ==false && move> 0)
			{
				_facingRight = true;
				transform.rotation = Quaternion.Euler(transform.rotation.x ,0 , transform.rotation.z);
			}


		RaycastHit2D hitInfo = Physics2D.Linecast (startPos.position,endPos.position,groundLayer.value);

		Debug.DrawLine (startPos.position, endPos.position);

		if (hitInfo != null) {
			
			_anim.SetBool ("Jump",false);
			_canJump = true;
		}
		if (Input.GetKeyDown(KeyCode.Space) && _canJump == true)
		{
			_anim.SetBool("Jump",true);
			_canJump = false;
			_myRigidbody.velocity = new Vector2(_myRigidbody.velocity.x,10);
		}
	}



	//button------------
	public void MoveJump()
	{
		_anim.Play ("Jump");
		_myRigidbody.velocity = new Vector2(_myRigidbody.velocity.x,10);
	}


	public void MoveRight()
		{
		CheckButton = true;
		 move = 1;
		}
	public void MoveUpRight()
	{
		CheckButton = false;
		move = 0;
	}

	public void MoveLeft()

	   {	
		CheckButton = true;	
		move = -1;
		}

}