using UnityEngine;
using System.Collections;

public class CheckCollisionDetection : MonoBehaviour {
	//public GameObject enemy;
	public GameObject charcontroll_obj;
	public CharacterInfomations charinfo;
	public GameObject charinfo_obj;
	public AudioSource audio;
	public AudioSource dead;
	public AnimationController player_anim;
	void Start(){
		//dead = enemy.GetComponent<AudioSource> ();
		charinfo = charinfo_obj.GetComponent<CharacterInfomations> ();

	}


	void OnCollisionEnter (Collision col){
		if (col.gameObject.tag == "Ground") {
			charcontroll_obj.GetComponent<CharController>().isGrounded = true;
			//print ("isGround");
		}

		if (col.gameObject.tag == "enemy") {
			charcontroll_obj.GetComponent<CharController>().isGrounded = true;
		}

		/*if (charinfo.hp <= 0) {
			dead.Play ();

			Destroy (this.gameObject);
		}*/


	}
}
