﻿using UnityEngine;
using System.Collections;

public class Credit : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void pushButton(){
		Debug.Log("push Button!!");
		Application.LoadLevel("Credit");
	}
}