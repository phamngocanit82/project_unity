using UnityEngine;
using System.Collections;

public class JachTheGiant_OptionsController : MonoBehaviour {

	[SerializeField]
	private GameObject easySign, mediumSign, hardSign;
	void Start () {
		SetTheDifficulty ();
	}
	void SetInitialDifficulty(string difficulty){
		switch (difficulty) {
		case "easy":
			mediumSign.SetActive(false);
			hardSign.SetActive(false);
			break;

		case "medium":
			easySign.SetActive(false);
			hardSign.SetActive(false);
			break;

		case "hard":
			mediumSign.SetActive(false);
			easySign.SetActive(false);
			break;
		}
	}
	void SetTheDifficulty(){
		if (JachTheGiant_GamePreferences.GetEasyDifficultyState () == 1) {
			SetInitialDifficulty("easy");
		}

		if (JachTheGiant_GamePreferences.GetMediumDifficultyState () == 1) {
			SetInitialDifficulty("medium");
		}

		if (JachTheGiant_GamePreferences.GetHardDifficultyState () == 1) {
			SetInitialDifficulty("hard");
		}
	}
	public void EasyDifficulty(){
		JachTheGiant_GamePreferences.SetEasyDifficultyState (1);
		JachTheGiant_GamePreferences.SetMediumDifficultyState (0);
		JachTheGiant_GamePreferences.SetHardDifficultyState (0);

		easySign.SetActive (true);
		mediumSign.SetActive(false);
		hardSign.SetActive(false);
	}
	public void MediumDifficulty(){
		JachTheGiant_GamePreferences.SetEasyDifficultyState (0);
		JachTheGiant_GamePreferences.SetMediumDifficultyState (1);
		JachTheGiant_GamePreferences.SetHardDifficultyState (0);

		easySign.SetActive (false);
		mediumSign.SetActive(true);
		hardSign.SetActive(false);
	}
	public void HardDifficulty(){
		JachTheGiant_GamePreferences.SetEasyDifficultyState (0);
		JachTheGiant_GamePreferences.SetMediumDifficultyState (0);
		JachTheGiant_GamePreferences.SetHardDifficultyState (1);

		easySign.SetActive (false);
		mediumSign.SetActive(false);
		hardSign.SetActive(true);
	}
	public void GoBackMainMenu(){
		JachTheGiant_SceneFader.instance.LoadLevel ("JachTheGiant_MainMenu");
	}
}
