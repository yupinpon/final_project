using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class meat2 : MonoBehaviour {
	public Text scoreText;
	public Text Wintext;
	public int ballValue;

	private int score;
	private int count;



	void Start () {
	score = 0;
	UpdateScore();	
	Wintext.text = "" ;

	count = 0;
	//UpdateCount();
	//winText.text= " ";
	}

	void OnCollisionEnter2D (Collision2D collision){
		if (collision.gameObject.tag == "Player") {
			score -= ballValue * 2;
			UpdateScore ();
		}
	}

	void UpdateScore () {
		StartCoroutine ("TimeScrip");
		scoreText.text = "Score 3 : " + score;
		if (score >= 3) {
			Wintext.text = "คุณชนะแล้ว";
		}
	}
	// Use this for initialization
}