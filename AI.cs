using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {
	public GameObject enemy_obj;
	public GameObject player_obj;
	public GameObject ccenemy_obj;
	private CharController charactorcontroller;
	//public characterController ch;
	public AnimationController enemy_anim;
	public ComandController ccenemy;
	public CharacterInfomations charinfo;

	private float random = 0;


	float enemy_position;
	float player_position;
	float interval;
	string enemy_state;

	// Use this for initialization
	void Start () {
		charactorcontroller = ccenemy_obj.GetComponent<CharController> ();
		InvokeRepeating ("RandomAction", 0, 1);

	}

	// Update is called once per frame
	void Update () {
		enemy_position = enemy_obj.GetComponent<Transform>().position.x;
		player_position = player_obj.GetComponent<Transform>().position.x;
		interval = enemy_position - player_position;
		State ();
		ccenemy.Enemy_Comand_Loop();
		enemy_anim.Place ();
		enemy_anim.BoolManeger();
		//enemy_anim.Possible ();
		//AIGuard_Ratio ();
		//enemy_anim.Anim();
		//enemy_anim.Place ();
		//AIDead ();
	}

	void State(){
		if (Mathf.Abs (interval) > 2) {
			enemy_state = "long";
		}else if(Mathf.Abs(interval) < 2 && Mathf.Abs(interval) > 1){
			enemy_state = "middle";
		}else{
			enemy_state = "short";
		}
	}

	private void RandomAction(){
		random = Random.value;
		if (enemy_state == "short") {
			if (random <= 0.4) {
				charactorcontroller.moveAIEnemy ("leave", enemy_position, player_position);
				RandomAttack();
			} else if (random > 0.4 && random < 0.8) {
				RandomAttack();
			} else {
				charactorcontroller.jumpAIEnemy();
			}
		}else if(enemy_state == "long") {
			if (random <= 0.3) {
				charactorcontroller.moveAIEnemy ("approach", enemy_position, player_position);
				RandomAttack();
			} else if (random > 0.3 && random < 0.8) {
				RandomAttack();
			} else {
				charactorcontroller.jumpAIEnemy();
			}
		}else if (enemy_state == "middle") {
			if (random <= 0.6) {
				RandomAttack();
			} else if (random > 0.6 && random < 0.8) {
				charactorcontroller.moveAIEnemy ("approach", enemy_position, player_position);
			}else if(random > 0.8 && random < 0.9){
				charactorcontroller.moveAIEnemy ("leave", enemy_position, player_position);
			}else{
				charactorcontroller.jumpAIEnemy();
			}
		}

	}

	private void RandomAttack(){
		random = Random.value;
		if (random <= 0.5) {
			enemy_anim.Punch_Anim ();
		} else if (random > 0.5 && random <= 0.8) {
			enemy_anim.Kick_Anim ();
		} else if(random > 0.8 && random <= 0.9){
			enemy_anim.Enemy_Hadooken();
		}else if(random > 0.9 && random <= 1.0){
			enemy_anim.Rising_P_Anim();
		}
	}

	/*private void AIGuard_Ratio(){
		float x = Random.value;
		if (x < 0.4) {
			charinfo.guard_flag = true;
		}
	}*/

	/*private void AIDead(){
		if (charinfo.hp <= 0) {
			Destroy (this.gameObject);
		}
	}*/






}
