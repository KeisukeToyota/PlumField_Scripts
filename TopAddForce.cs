using UnityEngine;
using System.Collections;

public class TopAddForce : MonoBehaviour {
	public Rigidbody enemy_rb;
	public Rigidbody player_rb;
	public CharController charcontrol;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Player" || col.gameObject.tag == "enemy") {
			charcontrol.isGrounded = true;
			enemy_rb.AddForce(new Vector3(-1000,0,0));
			player_rb.AddForce(new Vector3(1000,0,0));
		}
	}
}
