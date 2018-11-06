﻿using UnityEngine;
using System.Collections;

public class SelectCursor1P : MonoBehaviour {
	void Start () {
		GetComponent<SelectCursor1P>().enabled = true;
	}
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("right")) {
			transform.position += new Vector3 (-5.5f, 0f, 0f);
		}
		if (Input.GetKeyDown ("left")) {
			transform.position += new Vector3 (5.5f, 0f, 0f);
		}
		if (Input.GetKeyDown ("down")) {
			transform.position += new Vector3 (0f, -5.5f, 0f);
		}
		if (Input.GetKeyDown ("up")) {
			transform.position += new Vector3 (0f, 5.5f, 0f);
		}
		
		Vector3 pos = transform.position;
		pos.x = Mathf.Clamp(pos.x,-1.0f,21.0f);
		pos.y = Mathf.Clamp(pos.y,-2.5f,3.0f);
		
		transform.position = pos;

		if (Input.GetKeyDown ("space")) {
			GetComponent<SelectCursor1P>().enabled = false;
		}
	}
}
