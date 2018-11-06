using UnityEngine;
using System.Collections;

public class HPbar : MonoBehaviour {
	public CharacterInfomations charinfo;
	public BoxCollision boxcol;
	private Vector3 scale;
	private static int Count = 0;

	// Use this for initialization
	void Start () {
		scale = transform.localScale;
		//DontDestroyOnLoad (this);
	}

	// Update is called once per frame
	void FixedUpdate () {
		//print ("count : " + Count);
		Round ();
	}

	void Awake(){
		//DontDestroyOnLoad (this);
	}

	public int getCount(){
		return Count;
	}

	private void Round(){
		if (scale.x > 0) {
		//scale.x -= 0.01f;
		scale.x = charinfo.hp;
		charinfo.hp = scale.x;

		transform.localScale = scale;
		} else if(charinfo.hp <= 0){

		Count++;
		}
	}
}
