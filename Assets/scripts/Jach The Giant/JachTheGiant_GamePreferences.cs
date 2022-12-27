using UnityEngine;
using System.Collections;

public static class JachTheGiant_GamePreferences {
	public static string EasyDifficulty = "EasyDifficulty";
	public static string MediumDifficulty = "MediumDifficulty";
	public static string HardDifficulty = "HardDifficulty";

	public static string EasyDifficultyHighScore = "EasyDifficultyHighScore";
	public static string MediumDifficultyHighScore = "MediumDifficultyHighScore";
	public static string HardDifficultyHighScore = "HardDifficultyHighScore";

	public static string EasyDifficultyCoinScore = "EasyDifficultyCoinScore";
	public static string MediumDifficultyCoinScore = "MediumDifficultyCoinScore";
	public static string HardDifficultyCoinScore = "HardDifficultyCoinScore";

	public static string IsMusicOn = "IsMusicOn";


	public static int GetMusicState(){
		return PlayerPrefs.GetInt(JachTheGiant_GamePreferences.IsMusicOn);
	}
	public static void SetMusicState(int state){
		PlayerPrefs.SetInt (JachTheGiant_GamePreferences.IsMusicOn, state);
	}

	public static int GetEasyDifficultyState(){
		return PlayerPrefs.GetInt (JachTheGiant_GamePreferences.EasyDifficulty);
	}
	public static void SetEasyDifficultyState(int state){
		PlayerPrefs.SetInt (JachTheGiant_GamePreferences.EasyDifficulty, state);
	}

	public static int GetMediumDifficultyState(){
		return PlayerPrefs.GetInt (JachTheGiant_GamePreferences.MediumDifficulty);
	}
	public static void SetMediumDifficultyState(int state){
		PlayerPrefs.SetInt (JachTheGiant_GamePreferences.MediumDifficulty, state);
	}

	public static int GetHardDifficultyState(){
		return PlayerPrefs.GetInt (JachTheGiant_GamePreferences.HardDifficulty);
	}
	public static void SetHardDifficultyState(int state){
		PlayerPrefs.SetInt (JachTheGiant_GamePreferences.HardDifficulty, state);
	}

	public static int GetEasyDifficultyHighScore(){
		return PlayerPrefs.GetInt (JachTheGiant_GamePreferences.EasyDifficultyHighScore);
	}
	public static void SetEasyDifficultyHighScore(int state){
		PlayerPrefs.SetInt (JachTheGiant_GamePreferences.EasyDifficultyHighScore, state);
	}

	public static int GetMediumDifficultyHighScore(){
		return PlayerPrefs.GetInt (JachTheGiant_GamePreferences.MediumDifficultyHighScore);
	}
	public static void SetMediumDifficultyHighScore(int state){
		PlayerPrefs.SetInt (JachTheGiant_GamePreferences.MediumDifficultyHighScore, state);
	}

	public static int GetHardDifficultyHighScore(){
		return PlayerPrefs.GetInt (JachTheGiant_GamePreferences.HardDifficultyHighScore);
	}
	public static void SetHardDifficultyHighScore(int state){
		PlayerPrefs.SetInt (JachTheGiant_GamePreferences.HardDifficultyHighScore, state);
	}

	public static int GetEasyDifficultyCoinScore(){
		return PlayerPrefs.GetInt (JachTheGiant_GamePreferences.EasyDifficultyCoinScore);
	}
	public static void SetEasyDifficultyCoinScore(int state){
		PlayerPrefs.SetInt (JachTheGiant_GamePreferences.EasyDifficultyCoinScore, state);
	}

	public static int GetMediumDifficultyCoinScore(){
		return PlayerPrefs.GetInt (JachTheGiant_GamePreferences.MediumDifficultyCoinScore);
	}
	public static void SetMediumDifficultyCoinScore(int state){
		PlayerPrefs.SetInt (JachTheGiant_GamePreferences.MediumDifficultyCoinScore, state);
	}

	public static int GetHardDifficultyCoinScore(){
		return PlayerPrefs.GetInt (JachTheGiant_GamePreferences.HardDifficultyCoinScore);
	}
	public static void SetHardDifficultyCoinScore(int state){
		PlayerPrefs.SetInt (JachTheGiant_GamePreferences.HardDifficultyCoinScore, state);
	}
}
