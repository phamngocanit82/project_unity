using UnityEngine;
using System.Collections;

public class JachTheGiant_PlayerScore : MonoBehaviour {

	[SerializeField]
	private AudioClip coinClip, lifeClip;

	private JachTheGiant_CameraScript cameraScript;

	private Vector3 previousPosition;
	private bool countScore;

	public static int scoreCount;
	public static int lifeCount;
	public static int coinCount;

	void Awake(){
		cameraScript = Camera.main.GetComponent<JachTheGiant_CameraScript> ();
	}
	void Start () {
		previousPosition = transform.position;
		countScore = true;
	}

	void Update () {
		CountScore ();
	}
	void CountScore(){
		if (countScore) {
			if(transform.position.y < previousPosition.y){
				scoreCount++;
			}
			previousPosition = transform.position;
			JachTheGiant_GameplayController.instance.SetScore(scoreCount);
		}
	}

	void OnTriggerEnter2D(Collider2D target){
		if (target.tag == "Coin") {
			coinCount++;
			scoreCount += 200;

			JachTheGiant_GameplayController.instance.SetScore(scoreCount);
			JachTheGiant_GameplayController.instance.SetCoinScore(coinCount);

			AudioSource.PlayClipAtPoint(coinClip,transform.position);
			target.gameObject.SetActive(false);
		}

		if (target.tag == "Life") {
			lifeCount++;
			scoreCount += 300;

			JachTheGiant_GameplayController.instance.SetScore(scoreCount);
			JachTheGiant_GameplayController.instance.SetLifeScore(lifeCount);

			AudioSource.PlayClipAtPoint(lifeClip,transform.position);
			target.gameObject.SetActive(false);
		}

		if (target.tag == "Bounds" || target.tag == "Deadly") {
			cameraScript.moveCamera = false;
			countScore = false;

			transform.position = new Vector3(500,500,0);
			lifeCount--;
			JachTheGiant_GameManager.instance.CheckGameStatus(scoreCount,coinCount,lifeCount);
		}
	}
}
