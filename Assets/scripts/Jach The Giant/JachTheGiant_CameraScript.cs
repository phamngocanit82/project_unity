using UnityEngine;
using System.Collections;

public class JachTheGiant_CameraScript : MonoBehaviour {

	private float speed = 1f;
	private float acceleration = 0.2f;
	private float maxSpeed = 3.2f;

	private float easySpeed = 3.0f;
	private float mediumSpeed = 4.0f;
	private float hardSpeed = 5.0f;

	[HideInInspector]
	public bool moveCamera;

	void Start () {

		if (JachTheGiant_GamePreferences.GetEasyDifficultyState () == 1) {
			maxSpeed = easySpeed;
		}
		if (JachTheGiant_GamePreferences.GetMediumDifficultyState () == 1) {
			maxSpeed = mediumSpeed;
		}
		if (JachTheGiant_GamePreferences.GetHardDifficultyState () == 1) {
			maxSpeed = hardSpeed;
		}
		moveCamera = true;
	}

	void Update () {
		if (moveCamera) {
			MoveCamera();
		}
	}
	void MoveCamera(){
		Vector3 temp = transform.position;

		float oldY = temp.y;

		float newY = temp.y - (speed * Time.deltaTime);

		temp.y = Mathf.Clamp (temp.y,oldY,newY);

		transform.position = temp;

		speed += acceleration * Time.deltaTime;

		if (speed > maxSpeed)
			speed = maxSpeed;
	}
}
