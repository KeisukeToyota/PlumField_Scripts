using UnityEngine;
using System.Collections;

public class ShowText : MonoBehaviour {
	int x;
	// Use this for initialization
	void Start () {
		x = 0;
		GameObject.Find("AreYouReady").GetComponent<CanvasRenderer>().SetAlpha(0);
		GameObject.Find("Enter").GetComponent<CanvasRenderer>().SetAlpha(0);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			x = x+1;
		}
		if (x > 1) {
			GameObject.Find("AreYouReady").GetComponent<CanvasRenderer>().SetAlpha(1);
			GameObject.Find("Enter").GetComponent<CanvasRenderer>().SetAlpha(1);
				}

	}

}
