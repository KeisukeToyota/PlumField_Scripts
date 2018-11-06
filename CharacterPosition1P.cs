using UnityEngine;
using System.Collections;

public class CharacterPosition1P : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

			if (Input.GetKeyDown ("return")) {
					this.transform.position = new Vector3 (-1.5f, -1.35f, 0f);
			this.transform.rotation= Quaternion.Euler(0,90,0);
						}
}
}
