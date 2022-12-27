using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class JachTheGiant_GameplayController : MonoBehaviour {

	public static JachTheGiant_GameplayController instance;

	[SerializeField]
	private Text scoreText, coinText, lifeText, gameOverScoreText, gameOverCoinText;
	[SerializeField]
	private GameObject pausePanel, gameOverPannel;

	[SerializeField]
	private GameObject readyButton;

	void Awake () {
		MakeInstance ();
	}

	void Start(){
		Time.timeScale = 0f;
	}

	void MakeInstance(){
		if (instance == null) {
			instance = this;
		}
	}

	public void GameOverShowPanel(int finalScore,int finalCoinScore){
		gameOverPannel.SetActive (true);
		gameOverScoreText.text = finalScore.ToString ();
		gameOverCoinText.text = finalCoinScore.ToString ();
		StartCoroutine (GameOverLoadMainMenu());
		
	}

	IEnumerator GameOverLoadMainMenu(){
		yield return new WaitForSeconds (3f);
		JachTheGiant_SceneFader.instance.LoadLevel ("JachTheGiant_MainMenu");
	}

	public void PlayerDiedRestartTheGame(){
		StartCoroutine (PlayerDiedRestart ());
	}

	IEnumerator PlayerDiedRestart(){
		yield return new WaitForSeconds (1f);
		JachTheGiant_SceneFader.instance.LoadLevel ("JachTheGiant_Gameplay");
	}

	public void SetScore(int score){
		scoreText.text = "x" + score;
	}

	public void SetCoinScore(int coinScore){
		coinText.text = "x" + coinScore;
	}

	public void SetLifeScore(int lifeScore){
		lifeText.text = "x" + lifeScore;
	}
	public void PauseTheGame(){
		Time.timeScale = 0f;
		pausePanel.SetActive (true);
	}

	public void ResumeGame(){
		Time.timeScale = 1f;
		pausePanel.SetActive (false);
	}

	public void QuitGame(){
		Time.timeScale = 1f;
		JachTheGiant_SceneFader.instance.LoadLevel ("JachTheGiant_MainMenu");
	}

	public void StartTheGame(){
		Time.timeScale = 1f;
		readyButton.SetActive (false);
	}
}
