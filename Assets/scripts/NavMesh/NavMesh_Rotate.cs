using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavMesh_Rotate : MonoBehaviour {
	public float m_rotationSpeed = 15.0f;
	private void Update(){
		transform.Rotate(Vector3.up * (Time.deltaTime * m_rotationSpeed), Space.World);
	}
}
