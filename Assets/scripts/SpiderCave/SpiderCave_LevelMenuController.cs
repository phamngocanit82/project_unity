using UnityEngine;
using System.Collections;

public class SpiderCave_LevelMenuController : MonoBehaviour {

	public void PlayGame(){
		Application.LoadLevel("SpiderCave_GamePlay");
	}

	public void BackToMenu(){
		Application.LoadLevel("SpiderCave_MainMenu");
	}

}
