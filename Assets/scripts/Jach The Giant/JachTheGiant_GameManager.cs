using UnityEngine;
using System.Collections;

public class JachTheGiant_GameManager : MonoBehaviour {

	public static JachTheGiant_GameManager instance;

	[HideInInspector]
	public bool gameStartedFromMainMenu, gameRestartedAfterPlayerDied;

	[HideInInspector]
	public int score, coinScore,lifeScore;

	void Awake () {
		MakeSingleton ();
	}

	void Start(){
		InitializeVariables ();
		OnLevelWasLoaded1();
	}

	void OnLevelWasLoaded1(){

		if (Application.loadedLevelName == "JachTheGiant_GamePlay") {
			if(gameRestartedAfterPlayerDied){
				JachTheGiant_GameplayController.instance.SetScore(score);
				JachTheGiant_GameplayController.instance.SetCoinScore(coinScore);
				JachTheGiant_GameplayController.instance.SetLifeScore(lifeScore);

				JachTheGiant_PlayerScore.scoreCount = score;
				JachTheGiant_PlayerScore.coinCount = coinScore;
				JachTheGiant_PlayerScore.lifeCount = lifeScore;
			}else if(gameStartedFromMainMenu){
				JachTheGiant_PlayerScore.scoreCount = 0;
				JachTheGiant_PlayerScore.coinCount = 0;
				JachTheGiant_PlayerScore.lifeCount = 2;

				JachTheGiant_GameplayController.instance.SetScore(0);
				JachTheGiant_GameplayController.instance.SetCoinScore(0);
				JachTheGiant_GameplayController.instance.SetLifeScore(2);
			}
		}
	}

	void InitializeVariables(){
		if(!PlayerPrefs.HasKey("Game Initialized")){

			JachTheGiant_GamePreferences.SetEasyDifficultyState(0);
			JachTheGiant_GamePreferences.SetEasyDifficultyCoinScore(0);
			JachTheGiant_GamePreferences.SetEasyDifficultyHighScore(0);

			JachTheGiant_GamePreferences.SetMediumDifficultyState(1);
			JachTheGiant_GamePreferences.SetMediumDifficultyCoinScore(0);
			JachTheGiant_GamePreferences.SetMediumDifficultyHighScore(0);

			JachTheGiant_GamePreferences.SetHardDifficultyState(0);
			JachTheGiant_GamePreferences.SetHardDifficultyCoinScore(0);
			JachTheGiant_GamePreferences.SetHardDifficultyHighScore(0);

			JachTheGiant_GamePreferences.SetMusicState(0);

			PlayerPrefs.SetInt("Game Initialized",123);
		}
	}

	void MakeSingleton(){
		if (instance != null) {
			Destroy (gameObject);
		} else {
			instance = this;
			DontDestroyOnLoad(gameObject);
		}
	}

	public void CheckGameStatus(int score, int coinScore, int lifeScore){
		if (lifeScore < 0) {

			if(JachTheGiant_GamePreferences.GetEasyDifficultyState() == 1){

				int highScore = JachTheGiant_GamePreferences.GetEasyDifficultyHighScore();
				int coinHighScore = JachTheGiant_GamePreferences.GetEasyDifficultyCoinScore();

				if(highScore < score)
					JachTheGiant_GamePreferences.SetEasyDifficultyHighScore(score);

				if(coinHighScore < coinScore)
					JachTheGiant_GamePreferences.SetMediumDifficultyCoinScore(coinScore);
			}

			if(JachTheGiant_GamePreferences.GetMediumDifficultyState() == 1){

				int highScore = JachTheGiant_GamePreferences.GetMediumDifficultyHighScore();
				int coinHighScore = JachTheGiant_GamePreferences.GetMediumDifficultyCoinScore();

				if(highScore < score)
					JachTheGiant_GamePreferences.SetMediumDifficultyHighScore(score);

				if(coinHighScore < coinScore)
					JachTheGiant_GamePreferences.SetMediumDifficultyCoinScore(coinScore);
			}

			if(JachTheGiant_GamePreferences.GetHardDifficultyState() == 1){

				int highScore = JachTheGiant_GamePreferences.GetHardDifficultyHighScore();
				int coinHighScore = JachTheGiant_GamePreferences.GetHardDifficultyCoinScore();

				if(highScore < score)
					JachTheGiant_GamePreferences.SetHardDifficultyHighScore(score);

				if(coinHighScore < coinScore)
					JachTheGiant_GamePreferences.SetHardDifficultyCoinScore(coinScore);
			}
			gameStartedFromMainMenu = false;
			gameRestartedAfterPlayerDied = false;
			JachTheGiant_GameplayController.instance.GameOverShowPanel(score,coinScore);

		} else {
			this.score = score;
			this.coinScore = coinScore;
			this.lifeScore = lifeScore;

			gameStartedFromMainMenu = false;
			gameRestartedAfterPlayerDied = true;

			JachTheGiant_GameplayController.instance.PlayerDiedRestartTheGame();
		}
	}
}
