using UnityEngine;
using System.Collections;

public class FlappyBrid_SpawnerPipe : MonoBehaviour {
	[SerializeField]
	private GameObject pipeHolder;
	void Start () {
		StartCoroutine (Spawner ());
	}
	IEnumerator Spawner(){
		yield return new WaitForSeconds (1);
		Vector3 temp = pipeHolder.transform.position;
		temp.y = Random.Range (-2.5f, 2.5f);
		Instantiate (pipeHolder, temp, Quaternion.identity);
		yield return new WaitForSeconds(Random.Range (2.5f, 3.5f));
		yield return StartCoroutine(Spawner());
	}
}
