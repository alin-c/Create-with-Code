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
		if (gameObject.CompareTag("Player1")) {
			horizontalInput = Input.GetAxis("Horizontal1");
			forwardInput = Input.GetAxis("Vertical1");
		} else if (gameObject.CompareTag("Player2")) {
			horizontalInput = Input.GetAxis("Horizontal2");
			forwardInput = Input.GetAxis("Vertical2");
		}

		PlayerMove(forwardInput, horizontalInput);
	}

	void PlayerMove(float forwardInput, float horizontalInput) {
		transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
		transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
	}
}
