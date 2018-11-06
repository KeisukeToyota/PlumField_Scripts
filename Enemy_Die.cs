using UnityEngine;
using System.Collections;

public class Enemy_Die : MonoBehaviour {
	public CharacterInfomations charinfo;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Dei ();
	}

	private void Dei(){
		if (Input.GetKeyDown (KeyCode.D)) {
			charinfo.hp = 0;
		}
	}
}
