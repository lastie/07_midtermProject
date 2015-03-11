using UnityEngine;
using System.Collections;

public class windMill : MonoBehaviour {
	public float rotateSpeed = 1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Rotate (0f, rotateSpeed, 0f);
	}
}
