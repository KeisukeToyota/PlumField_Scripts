using UnityEngine;
using System.Collections;

public class HadoukenControl : MonoBehaviour {

	public int speed = 1;


	// Use this for initialization
	void Start () {
		//Scale ();
		//Scale ();
		GetComponent<Rigidbody> ().velocity = (transform.right.normalized * speed);
	}

	// Update is called once per frame
	void Update () {
		//GetComponent<Rigidbody> ().AddForce (Vector3.right * 10);
	}

	public void Enemy_Hadouken_Scale(string direction){
		Vector3 scale = transform.localScale;
		if (direction == "right") {
			//print ("if" + x);
			scale.x *= 1;
			transform.localScale = scale;
			//GetComponent<Rigidbody> ().velocity = -(transform.right.normalized * speed);
			GetComponent<Rigidbody> ().AddForce (Vector3.right * speed);
		} else if(direction == "left"){
			scale.x *= -1;
			//print ("else" + x);
			transform.localScale = scale;
			//GetComponent<Rigidbody> ().velocity = (transform.right.normalized * speed);
			GetComponent<Rigidbody> ().AddForce (Vector3.left * speed);
		}
	}

	public void Player_Hadouken_Scale(string direction){
		Vector3 scale = transform.localScale;
		if (direction == "right") {
			//print ("if" + x);
			scale.x *= -1;
			transform.localScale = scale;
			GetComponent<Rigidbody> ().velocity = -(transform.right.normalized * speed);
			//GetComponent<Rigidbody> ().AddForce (Vector3.left * speed);
		} else if(direction == "left"){
			scale.x *= -1;
			//print ("else" + x);
			transform.localScale = scale;
			GetComponent<Rigidbody> ().velocity = (transform.right.normalized * speed);
			//GetComponent<Rigidbody> ().AddForce (Vector3.right * speed);
		}
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Player") {
			print ("player");
			Destroy (this.gameObject);

		}
		if (col.gameObject.tag == "enemy") {
			Destroy (this.gameObject);
			print ("enemy");

		}

		if (col.gameObject.tag == "Wall") {
			Destroy (this.gameObject);
		}

		if (col.gameObject.tag == "Hadouken") {
			Destroy (this.gameObject);
			print ("enemy");
		}

		if(col.gameObject.tag == "parts_of_enemy"){
			Destroy(this.gameObject);
		}

		if(col.gameObject.tag == "parts_of_player"){
			Destroy(this.gameObject);
		}


	}

}
