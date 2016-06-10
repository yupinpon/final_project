using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreScence5 : MonoBehaviour {

	public Text scoreText;
	public Text GameOverText;
	public Text BestScoreOver;

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

	public void OnCollisionEnter2D(Collision2D collision)
	{
		int bestScore = PlayerPrefs.GetInt ("BestScore", 0);
		if (score > bestScore) 
		{
			PlayerPrefs.SetInt ("BestScore", score);
		}
		BestScoreOver.text = " " + PlayerPrefs.GetInt ("BestScore", 0);
	}
}



		

