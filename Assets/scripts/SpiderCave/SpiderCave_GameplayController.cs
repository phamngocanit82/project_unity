﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpiderCave_GameplayController : MonoBehaviour {

	[SerializeField]
	private GameObject pausePanel;

	[SerializeField]
	private Button resumeGame;

	public void PauseGame(){
		Time.timeScale = 0f;
		pausePanel.SetActive (true);
		resumeGame.onClick.RemoveAllListeners ();
		resumeGame.onClick.AddListener(()=>ResumeGame());
	}

	public void ResumeGame(){
		Time.timeScale = 1f;
		pausePanel.SetActive (false);
	}

	public void GoToMenu(){
		Time.timeScale = 1f;
		Application.LoadLevel ("SpiderCave_MainMenu");
	}

	public void RestartGame(){
		Time.timeScale = 1f;
		Application.LoadLevel ("SpiderCave_GamePlay");
	}

	public void PlayerDied(){
		Time.timeScale = 0f;
		pausePanel.SetActive (true);
		resumeGame.onClick.RemoveAllListeners ();
		resumeGame.onClick.AddListener(()=>RestartGame());
	}

}





















