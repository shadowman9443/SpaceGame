using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour {

	public float tumble;
	Rigidbody rigid2D;
	void Start ()
	{
		rigid2D = GetComponent<Rigidbody>();
		rigid2D.angularVelocity = Random.insideUnitSphere * tumble; 
	}
}
