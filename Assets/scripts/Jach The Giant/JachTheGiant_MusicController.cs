using UnityEngine;
using System.Collections;

public class JachTheGiant_MusicController : MonoBehaviour {

	public static JachTheGiant_MusicController instance;

	private AudioSource audioSource;

	void Awake () {
		MakeSingleton ();
		audioSource = GetComponent<AudioSource> ();
	}

	void MakeSingleton(){
		if (instance != null) {
			Destroy (gameObject);
		} else {
			instance = this;
			DontDestroyOnLoad(gameObject);
		}
	}

	public void PlayMusic(bool play){
		if (play) {
			if (!audioSource.isPlaying) {
				audioSource.Play ();
			}
		} else {
			if(audioSource.isPlaying){
				audioSource.Stop();
			}
		}
	}
}
