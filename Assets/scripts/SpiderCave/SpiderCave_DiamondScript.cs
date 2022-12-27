using UnityEngine;
using System.Collections;

public class SpiderCave_DiamondScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (SpiderCave_Door.instance != null) {
			SpiderCave_Door.instance.collectablesCount++;
		}
	}

	void OnTriggerEnter2D(Collider2D target){
		if (target.tag == "Player") {
			Destroy(gameObject);

			if(SpiderCave_Door.instance != null){
				SpiderCave_Door.instance.DecrementCollectables();
			}
		}
	}
}
