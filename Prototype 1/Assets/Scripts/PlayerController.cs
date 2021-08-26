using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	float speed = 5;
	float turnSpeed = 25;
	float horizontalInput;
	float forwardInput;

	void Start() {

	}

	void Update() {
		horizontalInput = Input.GetAxis("Horizontal");
		forwardInput = Input.GetAxis("Vertical");

		transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
		transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
	}
}
