using UnityEngine;
using System.Collections;

public class MoveSheep : MonoBehaviour {
	public AudioClip baa;
	public float loudness = 10f;
	Rigidbody rbody;
	public float forceStrength = 0.01f;
	public float turnStrength = 0.01f;
	public float jumpStrength = 1000f;
 	Vector3 initialPosition;

	public bool isJumping = false;

	void Start () {
		rbody = GetComponent<Rigidbody>();
		initialPosition = transform.position;
	}

	void FixedUpdate () {
		if (transform.position.y < initialPosition.y - 10) {
			transform.position = initialPosition;
		}

		rbody.AddForce (transform.forward * forceStrength * Input.GetAxis("Vertical"));
//		if (Input.GetKeyDown (KeyCode.W)) {
//			rbody.velocity += transform.forward * forceStrength;
//		}

		//rbody.velocity = transform.forward * forceStrength * Input.GetAxis ("Vertical");
		transform.Rotate(0f, turnStrength * Input.GetAxis ("Horizontal"), 0f);

		if (!isJumping && Input.GetKeyDown(KeyCode.Space)) {
			//rbody.AddForce(0f, jumpStrength, 0f);
			audio.PlayOneShot(baa, loudness);

			isJumping = true;
			rbody.velocity += new Vector3(0f, jumpStrength, 0f);
		}
	}

	void OnTriggerEnter(Collider ground){
		isJumping = false;
	}
}
