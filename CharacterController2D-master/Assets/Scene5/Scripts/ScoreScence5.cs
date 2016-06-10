using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreScence5 : MonoBehaviour {

	public Text scoreText;
	public Text GameOverText;

	private int score =0 ;

	public void OnTriggerEnter2D(Collider2D collider)
	{
		if(collider.gameObject.tag == "Score")
		{
			score++;
			scoreText.text = score.ToString();
			GameOverText.text = "Score  : " + score;
		}

	}
}



		

