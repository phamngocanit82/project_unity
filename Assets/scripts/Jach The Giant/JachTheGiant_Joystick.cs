using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class JachTheGiant_Joystick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {
	private JachTheGiant_PlayerJoystick playerMove;
	public void OnPointerDown(PointerEventData eventData){
		if (gameObject.name == "Left") {
			playerMove.SetMove (true);
		} else if (gameObject.name == "Right") {
			playerMove.SetMove (false);
		}
	}
	public void OnPointerUp(PointerEventData eventData){
		playerMove.StopMove ();
	}
	void Start () {
		playerMove = GameObject.Find ("Player").GetComponent<JachTheGiant_PlayerJoystick> ();
	}
}
