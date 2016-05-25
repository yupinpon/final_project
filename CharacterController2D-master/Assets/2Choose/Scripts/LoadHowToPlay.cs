using UnityEngine;
using System.Collections;

public class LoadHowToPlay : MonoBehaviour {


	public void ChangeScene(int sceneToChangeTo)
	{	
		Application.LoadLevel("HowToPlay");
	}
}

