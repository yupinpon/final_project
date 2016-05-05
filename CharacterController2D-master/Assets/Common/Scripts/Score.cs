using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	public Text scoreText;
	public Text Wintext;
	public Text HeartText;

	public int ballValue;
	public int heart;

	private int score;
	private int count;



	// Use this for initialization
	void Start () {
		score = 0;
		UpdateScore();	
		Wintext.text = "" ;
		heart = 100;

		count = 0;
		//UpdateCount();
		//winText.text= " ";
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
	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "cactus") {
			heart -= 10;
		}

		if(heart <= 0 ){
			heart = 0;
			Application.LoadLevel ("GameOver");
		}

	}

	void Update(){
		HeartText.text = "Heart : " +heart.ToString();
	}

		

	void UpdateScore () {
		StartCoroutine ("TimeScrip");
		scoreText.text = "Score 3 : " + score;

		}





	private IEnumerator TimeScrip(){
			if (score >= 3) {
				Wintext.text = "คุณชนะแล้ว";
			yield return new WaitForSeconds (2);
			Application.LoadLevel ("Scene3");
		}
			
		if (score <= -1) {
			Wintext.text = "คุณแพ้แล้ว";

			yield return new WaitForSeconds (2);
			Application.LoadLevel ("GameOver");
		}
		}
	}




