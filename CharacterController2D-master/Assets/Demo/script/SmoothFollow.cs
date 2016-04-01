using UnityEngine;
using System.Collections;



public class SmoothFollow : MonoBehaviour
{
	public Transform target;
	public float followSpeed = 2.0f;
	public new Transform transform;
	public Vector3 cameraOffset;
	
	private CharacterController2D Player;
	
	
	void Awake()
	{
		transform = gameObject.transform;
		Player = target.GetComponent<CharacterController2D>();
	}
	
	
	public void LateUpdate()
	{
		if( Player == null )
		{
			transform.position = Vector3.Lerp( transform.position, target.position - cameraOffset, followSpeed * Time.deltaTime );
			return;
		}

		if(Player.velocity.x > 0 )
		{
			transform.position = Vector3.Lerp( transform.position, target.position - cameraOffset, followSpeed * Time.deltaTime );
		}
		else
		{
			var leftOffset = cameraOffset;
			leftOffset.x *= -1;
			transform.position = Vector3.Lerp( transform.position, target.position - leftOffset, followSpeed * Time.deltaTime );
		}
	}
	
}
