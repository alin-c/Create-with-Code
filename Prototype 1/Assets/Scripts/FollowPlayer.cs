using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
	public GameObject player;
	Vector3 offset;
	Vector3 offsetBack = new Vector3(0, 5, -7);
	Vector3 offsetOn = new Vector3(0, 2, 1);
	bool cameraToggle = false;

	void LateUpdate() {
		if (Input.GetKeyDown(KeyCode.C)) {
			cameraToggle = !cameraToggle;
		}

		offset = cameraToggle ? offsetOn : offsetBack;
		transform.position = player.transform.position + offset;
	}
}
