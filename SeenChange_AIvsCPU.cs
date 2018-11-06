using UnityEngine;
using System.Collections;

public class SeenChange_AIvsCPU : MonoBehaviour {
	int x;
	// Use this for initialization
	void Start () {
		x = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			x = x+1;
		}
		if (x > 1) {
			if (Input.GetKeyDown (KeyCode.Return)) {
				Application.LoadLevel ("AIvsCPU");
			}
		}
	}
}
