using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class SpiderCave_Joystick : MonoBehaviour, IPointerUpHandler, IPointerDownHandler {

	private SpiderCave_PlayerScript player;

	void Awake(){
		player = GameObject.Find ("SpiderCave Player").GetComponent<SpiderCave_PlayerScript> ();
	}

	public void OnPointerDown(PointerEventData data){
		if (gameObject.name == "Left") {
			player.SetMoveLeft(true);
			//Debug.Log ("Left");
		} else {
			player.SetMoveLeft(false);
			//Debug.Log("Right");
		}
	}

	public void OnPointerUp(PointerEventData data){
		player.StopMoving ();
	}
}
