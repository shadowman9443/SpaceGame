using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	public float speed;
	Rigidbody rigid2D;
	void Start ()
	{
		rigid2D = GetComponent<Rigidbody>();
		rigid2D.velocity = transform.forward * speed;
	}
}
