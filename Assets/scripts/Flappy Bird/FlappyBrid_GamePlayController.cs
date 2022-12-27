using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FlappyBrid_GamePlayController : MonoBehaviour {
	public static FlappyBrid_GamePlayController instance;
	[SerializeField]
	private Button instructionButton;
	[SerializeField]
	private Text scoreText,endScoreText,bestScoreText;
	[SerializeField]
	private GameObject gameOverPanel, pausePanel;
	void Awake(){
		Time.timeScale = 0;
		_MakeInstance ();
	}
	void _MakeInstance(){
		if (instance == null) {
			instance = this;
		}
	}
	public void _InstructionButton(){
		Time.timeScale = 1;
		instructionButton.gameObject.SetActive (false);
	}
	public void _SetScore(int score){
		scoreText.text = "" + score;
	}
	public void _BirdDiedShowPanel(int score){
		gameOverPanel.SetActive (true);

		endScoreText.text = "" + score;
		if (score > FlappyBrid_GameManager.instance.GetHighScore ()) {
			FlappyBrid_GameManager.instance.SetHighScore (score);
		}
		bestScoreText.text = "" + FlappyBrid_GameManager.instance.GetHighScore();
	}
	public void _MenuButton(){
		Application.LoadLevel ("FlappyBrid_MainMenu");
	}
	public void _RestartGameButton(){
		Application.LoadLevel ("FlappyBrid_GamePlay");
	}
	public void _PauseButton(){
		Time.timeScale = 0;
		pausePanel.SetActive (true);
	}
	public void _ResumeButton(){
		Time.timeScale = 1;
		pausePanel.SetActive (false);
	}
}
