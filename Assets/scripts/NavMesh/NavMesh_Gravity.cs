﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavMesh_Gravity : MonoBehaviour {
	public Transform target;
	void Update () 
	{
		Vector3 relativePos = (target.position + new Vector3(0, 0.1f, 0)) - transform.position;
		Quaternion rotation = Quaternion.LookRotation(relativePos);

		Quaternion current = transform.localRotation;

		transform.localRotation = Quaternion.Slerp(current, rotation, Time.deltaTime);
		transform.Translate(0, 0, 0.8f * Time.deltaTime);
	}
}
