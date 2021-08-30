using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerRotator : MonoBehaviour {
	float speed = 1000;

	void Update() {
		transform.Rotate(Vector3.forward, Time.deltaTime * speed);
	}
}
