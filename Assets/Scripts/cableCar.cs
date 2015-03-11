using UnityEngine;
using System.Collections;

public class cableCar : MonoBehaviour {
	// Use this for initialization

	bool backward = true;
	float speed = 2f;

	Vector3 initialPosition;
	Vector3 finalPosition;

	void Start () {
		initialPosition = transform.position;
		finalPosition = transform.position + transform.forward * (-500f);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (backward) {
			transform.position -= transform.forward * speed;
		} else {
			transform.position += transform.forward * speed;
		}

		if (backward && transform.position.z <= finalPosition.z) {
			backward = false;
		} else if (!backward && transform.position.z >= initialPosition.z) {
			backward = true;
		}
	}
}
