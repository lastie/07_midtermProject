using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class textDisplay2 : MonoBehaviour {
	
	// Use this for initialization
	
	GameObject sheep, chimney1, chimney2, chimney3, chimney4, chimney5, chimney6;
	bool r1, r2, r3, r4, r5, r6; //to denote whether a chimney has been reached before;
	public int delivers = 0;
	
	
	void Start () {
		sheep  = GameObject.Find("sheep");
		chimney1 = GameObject.Find("chimney1");
		chimney2 = GameObject.Find("chimney2");
		chimney3 = GameObject.Find("chimney3");
		chimney4 = GameObject.Find("chimney4");
		chimney5 = GameObject.Find("chimney5");
		chimney6 = GameObject.Find("chimney6");
	}
	
	// Update is called once per frame
	void Update () {
		//string textBuffer = "Find a chimney to deliver pizza. \nPress [SPACE] to jump.";
		string textBuffer = "[Space] - jump \n [A] - forward \n [W] - backward \n [A][D] - rotate";
		textBuffer +="\nYou're a decent sheep who delivers pizza from chimneys for a living!";
		textBuffer += "\nFind all chimneys!";
		textBuffer += "\nYou've reached " + delivers.ToString() + " out of 6 chimneys.";

		if (delivers == 6) {
			textBuffer += "\nYou have delivered all the pizza. Thanks.";
		} else if (!r1 && Vector3.Distance(sheep.transform.position, chimney1.transform.position) < 20f) {
			textBuffer += "\nYou're at chimney #1. Press [F] to drop pizza down.";
			if (Input.GetKeyDown (KeyCode.F)) {
				delivers += 1;
				r1 = true;
			}
		} else if (!r2 && Vector3.Distance(sheep.transform.position, chimney2.transform.position) < 20f) {
			textBuffer += "\nYou're at a chimney #2. Press [F] to drop pizza down.";
			if (Input.GetKeyDown (KeyCode.F)) {
				delivers += 1;
				r2 = true;
			}
		} else if (!r3 && Vector3.Distance(sheep.transform.position, chimney3.transform.position) < 20f) {
			textBuffer += "\nYou're at a chimney #3. Press [F] to drop pizza down.";
			if (Input.GetKeyDown (KeyCode.F)) {
				delivers += 1;
				r3 = true;
			}
		} else if (!r4 && Vector3.Distance(sheep.transform.position, chimney4.transform.position) < 20f) {
			textBuffer += "\nYou're at a chimney #4. Press [F] to drop pizza down.";
			if (Input.GetKeyDown (KeyCode.F)) {
				delivers += 1;
				r4 = true;
			}
		} else if (!r5 && Vector3.Distance(sheep.transform.position, chimney5.transform.position) < 20f) {
			textBuffer += "\nYou're at a chimney #5. Press [F] to drop pizza down.";
			if (Input.GetKeyDown (KeyCode.F)) {
				delivers += 1;
				r5 = true;
			}
		} else if (!r6 && Vector3.Distance(sheep.transform.position, chimney6.transform.position) < 20f) {
			textBuffer += "\nYou're at a chimney #6. Press [F] to drop pizza down.";
			if (Input.GetKeyDown (KeyCode.F)) {
				delivers += 1;
				r6 = true;
			}
		}
		
		GetComponent<Text>().text = textBuffer;
	}
}