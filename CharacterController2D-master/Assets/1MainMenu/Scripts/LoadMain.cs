using UnityEngine;
using System.Collections;

public class LoadMain : MonoBehaviour {

	// Use this for initialization
	public void ChangeScene()

	{	
		Application.LoadLevel("ChooseAnimal");
		Debug.Log ("กดปุ่มแล้วนะ");
	}
}
