using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour {
	
	// Use this for initialization

	GameObject sheep, chimney;
	bool success = false;

	
	void Start () {
		sheep  = GameObject.Find("sheep");
		chimney = GameObject.Find("chimney");
	}
	
	// Update is called once per frame
	void Update () {
		string textBuffer = "Find a chimney to deliver pizza. \nPress [SPACE] to jump.";
		if (success) {
			textBuffer += "\nYou have delivered the pizza. Thanks.";
		} else if (Vector3.Distance(sheep.transform.position, chimney.transform.position) < 20f) {
				textBuffer += "\nYou're at the chimney. Press [F] to drop pizza down.";
				if (Input.GetKeyDown (KeyCode.F)) {
					success = true;
				}
		}
		
		GetComponent<Text>().text = textBuffer;
	}
}
