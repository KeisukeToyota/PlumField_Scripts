﻿using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void pushButton(){
		Debug.Log("push Button!!");
		Application.LoadLevel("TitleTest");
	}
}
