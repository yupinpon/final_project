using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonUI : MonoBehaviour {

		public float speed = 4, JumpMax = 8, HoriInput=0; 
		public LayerMask PlayerMask;                //เรียนใช้ Layer 

		[HideInInspector]                           //ซ่อน Field Fontface
		public bool Fontface = true;                //สถานะการหันหน้า
		
		private Rigidbody2D _myRigidbody;
		private Animator _anim;

		Transform  groundCheck;                     //เรียกใช้ Component Transform
		Rigidbody2D MyBody;                         //เรียกใช้ Component Rigidbody2D  

		[HideInInspector]
		public bool grounded = false;               //สถานะการสัมผัสกับพื้น
		
		[HideInInspector]
		public bool jumpStatus = false;             //สถานนะการกระโดด

		//AttackShooting Att;                         //เรียกใช้ Class AttackShooting
		//public int Jbt;                     //ค่าการกระโดดสำหรับนำไปตรวจสอบเงื่อนไขใน AnimationControl

		public static float PoX;

		void Awake () 
		{
			groundCheck = transform.Find("groungCheck"); //หา Game Object ชื่อ groungCheck
			MyBody = this.GetComponent<Rigidbody2D>();  //เรียกใช้ COmponent Rigidbody2D
		}	

		void Start()
		{
			PoX = -9.9f;
			PoX = PlayerPrefs.GetFloat("POX");
			transform.position = new Vector2(PoX, transform.position.y);
		}

		void FixedUpdate () 
		{
			//ตรวจสอบการชนกับพื้น
			grounded = Physics2D.Linecast(transform.position, groundCheck.position,
				1 << LayerMask.NameToLayer("Ground")); 

			//เงื่อนไขการเดิน และการกระโดด
/*		if (Player > 0 || Player== true)
			{
				if (HoriInput == 1)
				{
					Vector2 moveVel = MyBody.velocity;
					moveVel.x = HoriInput * speed;
					MyBody.velocity = moveVel;
				}
				else if (HoriInput == -1)
				{
					Vector2 moveVel = MyBody.velocity;
					moveVel.x = HoriInput * speed;
					MyBody.velocity = moveVel;
				}
				if (HoriInput > 0 && !Fontface)
					Inverse();
				else if (HoriInput < 0 && Fontface)
					Inverse();

			float move = Input.GetAxisRaw("Horizontal");
			_anim.SetFloat ("Speed", Mathf.Abs( move));
			_myRigidbody.velocity = new Vector2 (move * speed, _myRigidbody.velocity.y);

			}        
		}

		public void Jump() //กระโดด
		{
		if (Player== false)
			{
				jumpStatus = true;
			}
		}
		public void BreakJump() //หยุดการกระโดด
		{        
			jumpStatus = false;
      _anim= 0;
*/		}

		//รับค่าการเดิน
		public void StartMoving(float horizontalInput) 
		{
			HoriInput = horizontalInput;
		}    

		public void Inverse() //กลับด้านของตัวละครหันหน้าไปหันหน้าไปทางซ้าย
		{
			Fontface = !Fontface;
			Vector3 Scale = transform.localScale;
			Scale.x *= -1;
			transform.localScale = Scale;
		}

		//ตรวจสอบการชน
		void OnCollisionEnter2D(Collision2D collis)
		{
			if(collis.gameObject.tag == "Magin")
			{           
				HoriInput = 1;
			}




		}
	}
