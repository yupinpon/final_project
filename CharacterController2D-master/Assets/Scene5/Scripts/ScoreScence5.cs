using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreScence5 : MonoBehaviour {

	public int ballValue;
	public Text scoreText;
	public Text Wintext;
	public int winScore;
	public string scene;

	private int score;
	private int count;

	// Use this for initialization
	void Start () {
		score = 0;
		UpdateScore();	
		Wintext.text = "" ;

		count = 0;
	
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.tag == "meat") {
			score += ballValue;
			UpdateScore ();	
			//	Destroy (other.gameObject);
		}
		if (other.tag == "grass") {
			score -= ballValue;
			UpdateScore ();	
			//	Destroy (other.gameObject);
		}

	}


		void UpdateScore () {
	//	StartCoroutine ("TimeScrip");
			scoreText.text = "Score "+winScore+" : " + score;

		}

}
