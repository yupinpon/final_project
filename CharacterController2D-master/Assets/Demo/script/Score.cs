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
		StartCoroutine ("TimeScrip");
		scoreText.text = "Score 3 : " + score;

		}





	private IEnumerator TimeScrip(){
			if (score >= 3) {
				Wintext.text = "คุณชนะแล้ว";
			yield return new WaitForSeconds (2);
			Application.LoadLevel ("S3");
		}
			
		if (score <= -1) {
			Wintext.text = "คุณแพ้แล้ว";

			yield return new WaitForSeconds (2);
			Application.LoadLevel ("Game Over");
		}
		}
	}




