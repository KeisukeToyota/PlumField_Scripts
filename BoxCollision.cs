using UnityEngine;
using System.Collections;

public class BoxCollision : MonoBehaviour {
	public GameObject charcontroll_obj;
	public CharacterInfomations charinfo;
  public CharacterInfomations enemy_charinfo;
  public GameObject charinfo_obj;
	public AnimationController player_anim;
	public AudioSource audio;
	public string role;
	public Animator anim;
	public Animator enemy_anim;
	public GameObject judg;
	public GameObject enemy_judg;
	// Use this for initialization
	void Start () {
		judg = GameObject.Find("judg");
		enemy_judg = GameObject.Find("enemy__judg");

	}

	// Update is called once per frame
	void Update () {

		//string stCurrentDir = System.IO.Directory.GetCurrentDirectory();

		// カレントディレクトリを表示する
		//print("***************************" + stCurrentDir);

	}

	void OnTriggerEnter(Collider col){
		if ( col.tag == "parts_of_enemy" && role == "player" && (enemy_charinfo.attack_flag == true)){
			print ("HitPlayer " + col.name);
			float x = Input.GetAxisRaw ("Horizontal");
			if (charinfo.guard_flag == true && charcontroll_obj.GetComponent<CharController> ().player_position - charcontroll_obj.GetComponent<CharController> ().enemy_position < 0) {
				print (x);
				//player_anim.Guard_Anim();
				print ("Guard-1");
			} else if (charinfo.guard_flag == true && charcontroll_obj.GetComponent<CharController> ().player_position - charcontroll_obj.GetComponent<CharController> ().enemy_position > 0) {
				//print (x + " : " + (charcontroll_obj.GetComponent<CharController> ().player_position - charcontroll_obj.GetComponent<CharController> ().enemy_position));
				print (x);
				//player_anim.Guard_Anim();
				print ("Guard1");
			}else if(anim.GetCurrentAnimatorStateInfo (0).IsName ("guard")){
				print("ggg");
			} else {
				print("---------hit---------");
				charinfo.hp -= 0.1f;
				enemy_judg.SetActive(false);
				print ("judg     :    " + enemy_judg.active);
				charinfo.possible_trick = false;
				//charinfo.possible_trick = true;
				player_anim.Body_Damage();
				audio.Play ();
			}
			//charinfo.possible_trick == false &&
		}else if (col.tag == "parts_of_player" && role == "enemy" && (enemy_charinfo.attack_flag == true)) {
			float x = Input.GetAxisRaw ("Horizontal");
			if (charinfo.guard_flag == true && charcontroll_obj.GetComponent<CharController> ().player_position - charcontroll_obj.GetComponent<CharController> ().enemy_position < 0) {
				print (x);
				print ("Guard-1");
			}else if(anim.GetCurrentAnimatorStateInfo (0).IsName ("guard")){
				print("ggg");
			} else if (charinfo.guard_flag == true && charcontroll_obj.GetComponent<CharController> ().player_position - charcontroll_obj.GetComponent<CharController> ().enemy_position > 0) {
				//print (x + " : " + (charcontroll_obj.GetComponent<CharController> ().player_position - charcontroll_obj.GetComponent<CharController> ().enemy_position));
				print (x);
				print ("Guard1");
			}else{
				charinfo.hp -= 0.1f;
				judg.SetActive(false);
				print ("judg     :    " + judg.active);
				player_anim.Body_Damage();
				charinfo.possible_trick = false;
				//charinfo.possible_trick = true;
				audio.Play();
			}
		}else if(col.tag == "Hadouken" && role == "player"){
			if(!anim.GetCurrentAnimatorStateInfo(0).IsName("guard")){
				charinfo.hp -= 0.1f;
				player_anim.Body_Damage();
				charinfo.possible_trick = false;
				//charinfo.possible_trick = true;
				audio.Play();
			}
		}else if(col.tag == "Hadouken" && role == "enemy"){
			if(!anim.GetCurrentAnimatorStateInfo(0).IsName("guard")){
				charinfo.hp -= 0.1f;
				player_anim.Body_Damage();
				charinfo.possible_trick = false;
				//charinfo.possible_trick = true;
				audio.Play();
			}
		}
	}
}


// using UnityEngine;
// using System.Collections;
//
// public class BoxCollision : MonoBehaviour {
// 	public GameObject charcontroll_obj;
// 	public CharacterInfomations charinfo;
//   public CharacterInfomations enemy_charinfo;
//   public GameObject charinfo_obj;
// 	public AnimationController player_anim;
// 	public AudioSource audio;
// 	public string role;
// 	public Animator anim;
// 	public Animator enemy_anim;
//
// 	// Use this for initialization
// 	void Start () {
//
// 	}
//
// 	// Update is called once per frame
// 	void Update () {
//
// 		//string stCurrentDir = System.IO.Directory.GetCurrentDirectory();
//
// 		// カレントディレクトリを表示する
// 		//print("***************************" + stCurrentDir);
//
// 	}
//
// 	void OnTriggerEnter(Collider col){
// 		if (role == "enemy" && col.tag  == "parts_of_player") {
// 			print("********************");
// 		}
// 		if ( col.tag == "parts_of_enemy" && role == "player" && (enemy_charinfo.attack_flag == true)){
// 			print ("HitPlayer " + col.name);
// 			float x = Input.GetAxisRaw ("Horizontal");
// 			if (charinfo.guard_flag == true && charcontroll_obj.GetComponent<CharController> ().player_position - charcontroll_obj.GetComponent<CharController> ().enemy_position < 0) {
// 				print (x);
// 				//player_anim.Guard_Anim();
// 				print ("Guard-1");
// 			} else if (charinfo.guard_flag == true && charcontroll_obj.GetComponent<CharController> ().player_position - charcontroll_obj.GetComponent<CharController> ().enemy_position > 0) {
// 				print (x);
// 				print ("Guard1");
// 			} else {
// 				print("---------hit---------");
// 				charinfo.hp -= 0.1f;
// 				charinfo.possible_trick = false;
// 				player_anim.Body_Damage();
// 				audio.Play ();
// 			}
// 		}else if (col.tag == "parts_of_player" && role == "enemy" && (enemy_charinfo.attack_flag == true)) {
// 			float x = Input.GetAxisRaw ("Horizontal");
// 			if (charinfo.guard_flag == true && charcontroll_obj.GetComponent<CharController> ().player_position - charcontroll_obj.GetComponent<CharController> ().enemy_position < 0) {
// 				print (x);
// 				print ("Guard-1");
// 			} else if (charinfo.guard_flag == true && charcontroll_obj.GetComponent<CharController> ().player_position - charcontroll_obj.GetComponent<CharController> ().enemy_position > 0) {
// 				//print (x + " : " + (charcontroll_obj.GetComponent<CharController> ().player_position - charcontroll_obj.GetComponent<CharController> ().enemy_position));
// 				print (x);
// 				print ("Guard1");
// 			}else{
// 				charinfo.hp -= 0.1f;
// 				player_anim.Body_Damage();
// 				charinfo.possible_trick = false;
// 				//charinfo.possible_trick = true;
// 				audio.Play();
// 			}
// 		}
// 	}
// }
//
//
//
//
//
//
//
// // ﻿using UnityEngine;
// // using System.Collections;
// //
// // public class BoxCollision : MonoBehaviour {
// // 	public GameObject charcontroll_obj;
// // 	public CharacterInfomations charinfo;
// // 	public GameObject charinfo_obj;
// // 	public AnimationController player_anim;
// // 	public AudioSource audio;
// // 	public string role;
// // 	public Animator anim;
// // 	public Animator enemy_anim;
// //
// // 	// Use this for initialization
// // 	void Start () {
// //
// // 	}
// //
// // 	// Update is called once per frame
// // 	void Update () {
// //
// // 		//string stCurrentDir = System.IO.Directory.GetCurrentDirectory();
// //
// // 		// カレントディレクトリを表示する
// // 		//print("***************************" + stCurrentDir);
// //
// // 	}
// //
// // 	void OnTriggerEnter(Collider col){
// // 		if (role == "enemy" && col.tag  == "parts_of_player") {
// // 			print("********************");
// // 		}
// // 		//charinfo.possible_trick == false &&
// // 		if ( col.gameObject.tag == "parts_of_enemy" && role == "player" &&  (anim.GetCurrentAnimatorStateInfo(0).IsName("punch01") || anim.GetCurrentAnimatorStateInfo(0).IsName("punch02") || anim.GetCurrentAnimatorStateInfo(0).IsName("punch03") || anim.GetCurrentAnimatorStateInfo(0).IsName("kick01") || anim.GetCurrentAnimatorStateInfo(0).IsName("kick02") || anim.GetCurrentAnimatorStateInfo(0).IsName("kick03") || anim.GetCurrentAnimatorStateInfo(0).IsName("walk_forward") || anim.GetCurrentAnimatorStateInfo(0).IsName("Idle") || anim.GetCurrentAnimatorStateInfo(0).IsName("jump"))) {
// // 			print ("HitPlayer " + col.name);
// // 			float x = Input.GetAxisRaw ("Horizontal");
// // 			if (charinfo.guard_flag == true && charcontroll_obj.GetComponent<CharController> ().player_position - charcontroll_obj.GetComponent<CharController> ().enemy_position < 0) {
// // 				print (x);
// // 				//player_anim.Guard_Anim();
// // 				print ("Guard-1");
// // 			} else if (charinfo.guard_flag == true && charcontroll_obj.GetComponent<CharController> ().player_position - charcontroll_obj.GetComponent<CharController> ().enemy_position > 0) {
// // 				//print (x + " : " + (charcontroll_obj.GetComponent<CharController> ().player_position - charcontroll_obj.GetComponent<CharController> ().enemy_position));
// // 				print (x);
// // 				//player_anim.Guard_Anim();
// // 				print ("Guard1");
// // 			} else if(anim.GetCurrentAnimatorStateInfo(0).IsName("punch01") || anim.GetCurrentAnimatorStateInfo(0).IsName("punch02") || anim.GetCurrentAnimatorStateInfo(0).IsName("punch03") || anim.GetCurrentAnimatorStateInfo(0).IsName("kick01") || anim.GetCurrentAnimatorStateInfo(0).IsName("kick02") || anim.GetCurrentAnimatorStateInfo(0).IsName("kick03") || anim.GetCurrentAnimatorStateInfo(0).IsName("walk_forward") || anim.GetCurrentAnimatorStateInfo(0).IsName("Idle") || anim.GetCurrentAnimatorStateInfo(0).IsName("jump")){
// // 				print("---------hit---------");
// // 				charinfo.hp -= 0.1f;
// // 				charinfo.possible_trick = false;
// // 				//charinfo.possible_trick = true;
// // 				player_anim.Body_Damage();
// // 				audio.Play ();
// // 			}
// // 			//charinfo.possible_trick == false &&
// // 		} else if (col.gameObject.tag == "parts_of_player" && role == "enemy" &&  (enemy_anim.GetCurrentAnimatorStateInfo(0).IsName("punch01") || enemy_anim.GetCurrentAnimatorStateInfo(0).IsName("punch02") || enemy_anim.GetCurrentAnimatorStateInfo(0).IsName("punch03") || enemy_anim.GetCurrentAnimatorStateInfo(0).IsName("kick01") || enemy_anim.GetCurrentAnimatorStateInfo(0).IsName("kick02") || enemy_anim.GetCurrentAnimatorStateInfo(0).IsName("kick03") || enemy_anim.GetCurrentAnimatorStateInfo(0).IsName("walk_forward") || enemy_anim.GetCurrentAnimatorStateInfo(0).IsName("Idle") || enemy_anim.GetCurrentAnimatorStateInfo(0).IsName("jump"))) {
// // 			print ("HitEnemy");
// // 			float x = Input.GetAxisRaw ("Horizontal");
// // 			if (charinfo.guard_flag == true && charcontroll_obj.GetComponent<CharController> ().player_position - charcontroll_obj.GetComponent<CharController> ().enemy_position < 0) {
// // 				print (x);
// // 				print ("Guard-1");
// // 			} else if (charinfo.guard_flag == true && charcontroll_obj.GetComponent<CharController> ().player_position - charcontroll_obj.GetComponent<CharController> ().enemy_position > 0) {
// // 				//print (x + " : " + (charcontroll_obj.GetComponent<CharController> ().player_position - charcontroll_obj.GetComponent<CharController> ().enemy_position));
// // 				print (x);
// // 				print ("Guard1");
// // 			} else if(enemy_anim.GetCurrentAnimatorStateInfo(0).IsName("punch01") || enemy_anim.GetCurrentAnimatorStateInfo(0).IsName("punch02") || enemy_anim.GetCurrentAnimatorStateInfo(0).IsName("punch03") || enemy_anim.GetCurrentAnimatorStateInfo(0).IsName("kick01") || enemy_anim.GetCurrentAnimatorStateInfo(0).IsName("kick02") || enemy_anim.GetCurrentAnimatorStateInfo(0).IsName("kick03") || enemy_anim.GetCurrentAnimatorStateInfo(0).IsName("walk_forward") || enemy_anim.GetCurrentAnimatorStateInfo(0).IsName("Idle") || enemy_anim.GetCurrentAnimatorStateInfo(0).IsName("jump")){
// // 				charinfo.hp -= 0.1f;
// // 				player_anim.Body_Damage();
// // 				charinfo.possible_trick = false;
// // 				//charinfo.possible_trick = true;
// // 				audio.Play();
// // 			}
// // 		}
// // 	}
// // }
