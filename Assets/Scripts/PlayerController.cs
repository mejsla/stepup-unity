using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;

	public float speed = 0;

	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	void FixedUpdate () {
		float verticalForce = Input.GetAxis ("Vertical");
		float horizontalForce = Input.GetAxis ("Horizontal");

		Vector3 vectorForce = new Vector3 (horizontalForce, 0, verticalForce);

		rb.AddForce (vectorForce * speed);
	}
}
