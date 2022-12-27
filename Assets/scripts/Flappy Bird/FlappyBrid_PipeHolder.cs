using UnityEngine;
using System.Collections;

public class FlappyBrid_PipeHolder : MonoBehaviour {
	public float speed;
	void Start () {

	}
	void Update () {
		if (FlappyBrid_BirdController.instance != null) {
			if (FlappyBrid_BirdController.instance.flag == 1) {
				Destroy (GetComponent<FlappyBrid_PipeHolder> ());
			}
		}
		_PipeMovement ();
	}
	void _PipeMovement(){
		Vector3 temp = transform.position;
		temp.x -= speed * Time.deltaTime;
		transform.position = temp;
	}
	void OnTriggerEnter2D(Collider2D target){
		if (target.tag == "Destroy") {
			Destroy (gameObject);
		}
	}
}
