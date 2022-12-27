using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class JachTheGiant_MainMenuController : MonoBehaviour {

	[SerializeField]
	private Button musicBtn;

	[SerializeField]
	private Sprite[] musicIcons;
	void Start () {
		CheckToPlayTheMusic ();

	}

	void CheckToPlayTheMusic(){
		if (JachTheGiant_GamePreferences.GetMusicState () == 1) {
			JachTheGiant_MusicController.instance.PlayMusic (true);
			musicBtn.image.sprite = musicIcons [1];
		} else {
			JachTheGiant_MusicController.instance.PlayMusic (false);
			musicBtn.image.sprite = musicIcons [0];
		}
	}
	public void StartGame(){
		JachTheGiant_GameManager.instance.gameStartedFromMainMenu = true;
		JachTheGiant_SceneFader.instance.LoadLevel ("JachTheGiant_Gameplay");
	}

	public void HighscoreMenu(){
		JachTheGiant_SceneFader.instance.LoadLevel ("JachTheGiant_HighscoreScene");
	}
	public void OptionsMenu(){
		JachTheGiant_SceneFader.instance.LoadLevel ("JachTheGiant_OptionMenu");
	}

	public void QuitGame(){
		Application.Quit ();
	}
	public void MusicButton(){
		if (JachTheGiant_GamePreferences.GetMusicState () == 0) {
			JachTheGiant_GamePreferences.SetMusicState(1);
			JachTheGiant_MusicController.instance.PlayMusic(true);
			musicBtn.image.sprite = musicIcons[1];
		}else if(JachTheGiant_GamePreferences.GetMusicState() == 1){
			JachTheGiant_GamePreferences.SetMusicState(0);
			JachTheGiant_MusicController.instance.PlayMusic(false);
			musicBtn.image.sprite = musicIcons[0];
		}
	}

}











































































