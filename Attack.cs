using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {
	public HP enemy_hp;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider col){
		if (col.gameObject.tag == "enemy") {
			Debug.Log("Hit!");
			enemy_hp.hp = enemy_hp.hp - 10;
		}
	}

}