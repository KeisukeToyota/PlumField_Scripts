using UnityEngine;
using System.Collections;

public class View : MonoBehaviour {

	public int defaultpoint;
	private static bool created = false;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
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
				} 
		else {
			GetComponent<Renderer> ().enabled = false;
				}
		if (Input.GetKeyDown ("space")) {
			if(defaultpoint==10){
				if(!created){ 
					DontDestroyOnLoad(this); 
					created = true; 
				}
			}
			GetComponent<View> ().enabled = false;

	}

}
}

