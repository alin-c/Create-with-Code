using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleNPC : MonoBehaviour {
	float maxSpeed = 10;
	readonly System.Random rand = new System.Random();

	void Update() {
		transform.Translate(Vector3.forward * Time.deltaTime * maxSpeed * (float)rand.NextDouble());
	}
}
