using UnityEngine;
using System.Collections;

public class StartGameManneger : MonoBehaviour {

	// Use this for initialization
	public void Start () {

	}
	
	// Update is called once per frame
	public void Update () {
		StartGame();
	}

	public void StartGame(){
		if (Input.GetKey (KeyCode.Return)) {
			print ("OK!");
			Application.LoadLevel("vsCPU");

		}
	}
}
