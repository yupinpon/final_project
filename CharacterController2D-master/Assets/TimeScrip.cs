using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeScrip : MonoBehaviour {
	public float myTimer = 10;
	private Text timerText;

	// Use this for initialization
	void Start () {
		timerText = GetComponent<Text> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		myTimer -= Time.deltaTime;
		timerText.text = "Time : " +myTimer.ToString("f0");
		print (myTimer);

		if (myTimer <= 0){
			Application.LoadLevel("Game over");
		}
	
	}
}
