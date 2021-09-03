using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float horizontalInput;
	public float speed = 10;

	void Update() {
		horizontalInput = Input.GetAxis("Horizontal");
		transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);
	}
}
