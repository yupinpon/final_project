using UnityEngine;
using System.Collections;

public class ButtonControl : MonoBehaviour {

	public Animator Character;
	public GameObject Charac;



	public void Left(){

		Character.Play ("Run");
		Character.transform.rotation = Quaternion.Euler (transform.rotation.x, 180, transform.rotation.z);

	}
	public void Right(){

		Character.Play ("Run");


	}





}
