using UnityEngine;
using System.Collections;

public class JachTheGiant_CloudCollector : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D targer){
		if (targer.tag == "Cloud" || targer.tag == "Deadly") {
				targer.gameObject.SetActive(false);
		}
	}
}
