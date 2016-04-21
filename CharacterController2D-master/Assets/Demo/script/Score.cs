using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	public Text scoreText;
	public Text Wintext;
	public int ballValue;

	private int score;
	private int count;


	// Use this for initialization
	void Start () {
		score = 0;
		UpdateScore();	
		Wintext.text = "" ;

		count = 0;
		//UpdateCount();
		//winText.text= " ";
	}

	void OnTriggerEnter2D(){
		
			score -=  ballValue ;
			UpdateScore ();	
		}


	
/*
	void OnTriggerEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "meat") {
			score +=  ballValue ;
			UpdateScore ();	
		}

	} */
		
	/*
	void OnCollisionEnter2D (Collision2D collision){
		if (collision.gameObject.tag == "meat") {
			score -= ballValue * 2;
			UpdateScore ();
		}
	}

	void OnCollisionEnter2D2 (Collision2D collision){
		if (collision.gameObject.tag == "grass") {
			score -= ballValue - 2;
			UpdateScore ();
		}
	}
		*/

	void UpdateScore () {
		StartCoroutine ("TimeScrip");
		scoreText.text = "Score 3 : " + score;
		if (score >= 3) {
			Wintext.text = "คุณชนะแล้ว";
		}
		if (score <= -1 ) {
			Wintext.text = "คุณแพ้แล้ว";
		}
	}


	private IEnumerator TimeScrip(){
		if (score >= 3) {
			yield return new WaitForSeconds (1);
			Application.LoadLevel ("S3");
		}
	}

}