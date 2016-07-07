using UnityEngine;
using System.Collections;

public class LoadScene_Tiger : MonoBehaviour {


	// Use this for initialization
	public void ChangeScene()

	{	
		Application.LoadLevel("Scene1_Tiger");
		Debug.Log ("Scene1_Tiger");
	}

}

