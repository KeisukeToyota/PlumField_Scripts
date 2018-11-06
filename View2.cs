using UnityEngine;
using System.Collections;

public class View2 : MonoBehaviour {
	
	public int defaultpoint;
	private static bool created = false;
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
		if (x == 1) {
						if (Input.GetKeyDown ("right")) {
								defaultpoint = defaultpoint + 1;
								if (defaultpoint > 10) {
										defaultpoint = 0;
								}
						}
						if (Input.GetKeyDown ("left")) {
								defaultpoint = defaultpoint - 1;
								if (defaultpoint < 0) {
										defaultpoint = 10;
								}
			
						}
						if (defaultpoint == 10) {
								GetComponent<Renderer> ().enabled = true;
						} else {
								GetComponent<Renderer> ().enabled = false;
						}
				}
		if (x>1) {
			x=2;
			if(defaultpoint==10){
				if(!created){ 
					DontDestroyOnLoad(this); 
					created = true; 
				}
			}
			GetComponent<View2> ().enabled = false;
		}
		
	}
}
