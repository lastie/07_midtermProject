//using UnityEngine;
//using System.Collections;
//
//public class NewJumpScript : MonoBehaviour {
//	Rigidbody rbody;
//	Vector3 initialPosition = new Vector3(-15.75f, 100.3f, 89.701f);
//
//	public float jumpStr;
//	public float jumpSpd;
//	public bool isJumping = false;
//	public bool canJumpAgain = false; // When true, it means the sheep is in 1st jummp.
//	public float jumpFrameCount = 0f;
//	public float jumpFrameMax = 80f;
//	public float jumpIniSpd = 1f;
//	public float jumpAcce = jumpIniSpd / (jumpFrameMax/2f); //Acceleration
//
//	// Use this for initialization
//	void Start () {
//		Physics.gravity = new Vector3(0f, -40f, 0f);
//		rbody = GetComponent<Rigidbody>();
//
//	}
//	
//	// Update is called once per frame
//	void FixedUpdate () {
//		if (transform.position.y < 30) {
//			transform.position = initialPosition;
//		}
//
//		if (!isJumping && !canJumpAgain) { // isn't jumping at all
//			if (Input.GetKeyDown(KeyCode.Space)) {
//				isJumping = true;
//				canJumpAgain = true;
//			}
//		} else if (isJumping && canJumpAgain) { // is in 1st jump
//			transform.position += new Vector3 (0f, (jumpIniSpd - jumpFrameCount * jumpAcce), 0f); // v = v_initial - a*t
//			jumpFrameCount += 1;
//
//			if (Input.GetKeyDown (KeyCode.Space)) {
//				jumpFrameCount = 0;
//				canJumpAgain = false;
//			}
//
//		} else if (isJumping && !canJumpAgain) { // is in 2nd jump
//			transform.position += new Vector3 (0f, (jumpIniSpd - jumpFrameCount * jumpAcce), 0f);
//			rbody.freezeRotationX
//			transform.Rotate(0f,0f);
//		}
//	}
//
//	void OnCollisionEnter () {
//		isJumping = false;
//		canJumpAgain = false;
//	}
//}
