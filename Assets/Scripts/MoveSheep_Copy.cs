using UnityEngine;
using System.Collections;

public class MoveSheep_Copy : MonoBehaviour {
	Rigidbody rbody;

	public float forceStrength = 0.01f;
	public float turnStrength = 0.01f;
	
	//public float gravity = 10f;

	float jumpHeight;
	float jumpSpeed;
	float jumpFrameCount = 5000f;

	public bool isSoaring = false;
	public bool isOnGround = true;
	
	public Vector3 initialPosition = new Vector3(-15.75f, 100.3f, 89.701f);
	//If the sheep falls below a certain y, it will respawn.

	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody>();
		//Physics.gravity = new Vector3(0f, -gravity, 0f);
		Physics.gravity = new Vector3 (0f, -40f, 0f);
	}	
	
	// Update is called once per frame
	void FixedUpdate () {
		if (transform.position.y < 30) {
			transform.position = initialPosition;
		}

		rbody.AddForce (transform.forward * forceStrength * Input.GetAxis("Vertical"));
		transform.Rotate(0f, turnStrength * Input.GetAxis ("Horizontal"), 0f);
//		if (Input.GetKey(KeyCode.Space)) {
//		rbody.AddForce (transform.up * jumpStrength);
		//if (Input.GetKeyDown(KeyCode.Space)) {
		//	rbody.transform.position += jumpStrength * (Vector3.up);

		// If you hit jump, in the next 100 frames, the stuff will climb up 1 unit in each frame
		// Also you shouldn' jump when you're not on the ground.

		//On the ground, soaring, falling
		// isSoaring = soaring, on the ground = !soaring and !falling, !is Soaring = falling
		// If count = 60 then you're back on the ground. Have to use the symmetry. To do this I need the value of gravity.
		if (!isSoaring) { //If the sheep isn't soaring
			if (Input.GetKeyDown (KeyCode.Space)) {
				isSoaring = true;
				//isOnGround = false;
			}
		} else {
			if (jumpFrameCount > 0) { //If the sheep is soaring
				transform.position += new Vector3 (0f, 1f - (50f - jumpFrameCount) * 0.02f, 0f);
				jumpFrameCount -= 1f;
			} else { //If the sheep is falling;
				isSoaring = false;
				jumpFrameCount = 50;
			}
		}
	}
}
