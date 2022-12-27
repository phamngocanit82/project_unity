using UnityEngine;
using System.Collections;

public class JachTheGiant_CollectableScript : MonoBehaviour {

	void OnEnable(){
		Invoke ("DestroyCollectable",6f);
	}

	void DestroyCollectable(){
		gameObject.SetActive (false);
	}
}
