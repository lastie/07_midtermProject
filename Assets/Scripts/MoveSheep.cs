using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoveSheep : MonoBehaviour {
	public AudioClip baa;
	public float loudness = 10f;
	Rigidbody rbody;
	public float forceStrength = 0.01f;
	public float turnStrength = 0.01f;
	public float jumpStrength = 1000f;
 	Vector3 initialPosition;
//	GameObject text;
	Vector3 c1, c2, c3, c4, c5, c6; //Chimneys
	bool r1, r2, r3, r4, r5, r6;
	bool gameOver;



	public bool isJumping = false;

	void Start () {
		rbody = GetComponent<Rigidbody>();
		initialPosition = transform.position;
		c1 = GameObject.Find("chimney1").transform.position;
		c2 = GameObject.Find("chimney2").transform.position;
		c3 = GameObject.Find("chimney3").transform.position;
		c4 = GameObject.Find("chimney4").transform.position;
		c5 = GameObject.Find("chimney5").transform.position;
		c6 = GameObject.Find("chimney6").transform.position;

	}

	void FixedUpdate () {
		//Create checkpoints
//		if (text.r4) {
//			initialPosition = new Vector3 (-809.3f, 303.21f, 28f);
//		}
		if (!gameOver) {
			if (!r1 && Vector3.Distance(transform.position, c1) <= 20f) {
				initialPosition = transform.position;
				r1 = true;
			} else if (!r2 && Vector3.Distance(transform.position, c2) <= 20f) {
				initialPosition = transform.position;
				r2 = true;
			} else if (!r3 && Vector3.Distance(transform.position, c3) <= 20f) {
				initialPosition = transform.position;
				r3 = true;
			} else if (!r4 && Vector3.Distance(transform.position, c4) <= 20f) {
				initialPosition = transform.position;
				r4 = true;
			} else if (!r5 && Vector3.Distance(transform.position, c5) <= 20f) {
				initialPosition = transform.position;
				r5 = true;
			} else if (!r6 && Vector3.Distance(transform.position, c6) <= 20f) {
				initialPosition = transform.position;
				r6 = true;
			}
			
			if (transform.position.y < initialPosition.y - 50f) {
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

		// Check if game is over
		if (r1 && r2 && r3 && r4 && r5 && r6) {
			gameOver = true;
		}

	}

	void OnTriggerEnter(Collider ground){
		isJumping = false;
	}
}
