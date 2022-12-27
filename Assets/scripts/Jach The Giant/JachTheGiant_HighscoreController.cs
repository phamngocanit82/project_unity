using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class JachTheGiant_HighscoreController : MonoBehaviour {

	[SerializeField]
	private Text scoreText,coinText;

	void Start () {
		SetScoreBasedOnDifficulty ();
	}

	void SetScore(int score,int coinScore){
		scoreText.text = score.ToString ();
		coinText.text = coinScore.ToString ();
	}

	void SetScoreBasedOnDifficulty(){

		if (JachTheGiant_GamePreferences.GetEasyDifficultyState () == 1) {
			SetScore(JachTheGiant_GamePreferences.GetEasyDifficultyHighScore(), JachTheGiant_GamePreferences.GetEasyDifficultyCoinScore());
		}
		if (JachTheGiant_GamePreferences.GetMediumDifficultyState () == 1) {
			SetScore(JachTheGiant_GamePreferences.GetMediumDifficultyHighScore(), JachTheGiant_GamePreferences.GetMediumDifficultyCoinScore());
		}
		if (JachTheGiant_GamePreferences.GetHardDifficultyState () == 1) {
			SetScore(JachTheGiant_GamePreferences.GetHardDifficultyHighScore(), JachTheGiant_GamePreferences.GetHardDifficultyCoinScore());
		}

	}

	public void GoBackMainMenu()
	{
		JachTheGiant_SceneFader.instance.LoadLevel ("JachTheGiant_MainMenu");
	}
}
