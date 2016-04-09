using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	public Text scoreText;
	public Text Wintext;
	public int ballValue;

	private int score;

	// Use this for initialization
	void Start () {
		score = 0;
		UpdateScore();	
		Wintext.text = "" ;
	}


	void OnTriggerEnter2D(){
		score += ballValue;
		UpdateScore();

	}
	void OnCollisionEnter2D (Collision2D collision){
		if (collision.gameObject.tag == "grass1") {
			score -= ballValue * 2;
			UpdateScore();
		}
	}

	void UpdateScore () {

		scoreText.text = "Score 3 : " + score;
		if (score >= 3) {
			Wintext.text = "คุณชนะแล้ว";
		}
	
	}
}