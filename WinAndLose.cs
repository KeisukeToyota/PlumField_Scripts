using UnityEngine;
using System.Collections;

public class WinAndLose : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Return)) {
			Application.LoadLevel("Title01");
		}
	
	}
}
