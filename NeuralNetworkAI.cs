using UnityEngine;
using System;
using System.Collections;

public class NeuralNetworkAI : MonoBehaviour {

	//public NeuralNetwork[] nn;
	public string inputresult;
	private static double interval;
	public static float  enemy_position;
	public static float player_position;
	private string enemy_state;


	public GameObject enemy_obj;
	public GameObject player_obj;
	public Animator anim;
	public GameObject animobj;
	public GameObject charobj;
	public AnimationController animControl;
	public CharController charControl;

	public ComandController ccenemy;
	private string str;
	public CharacterInfomations charinfo;
	//private GameObject selectAI;
	//public string selectAI;


	// Use this for initialization
	void Start () {
		//selectAI = GetComponent<Transform> ().root.gameObject;
	}

	// Update is called once per frame
	void Update () {
		//Select ();
		//print ("aaaaaaaaaaaaaaaaaaaaa  " + inputresult);

		//ActionDecision (inputresult);
		animControl.Place ();
		ccenemy.Enemy_Comand_Loop ();
		enemy_position = enemy_obj.GetComponent<Transform>().position.x;
		player_position = player_obj.GetComponent<Transform>().position.x;
		//interval = Math.Abs(enemy_position - player_position);
		//interval = Math.Abs (player_obj.player_vec.x - charinfo.player_vec.x);
		interval = Math.Abs (getEnemyPosition() - getPlayerPosition());

	}

	public string MoveDecision(string inputresult){
		double a = double.Parse (inputresult);
		//print ("a :  " + a);
		//print ("enemy_position : " + getEnemyPosition());
		//print ("player_position : " + getPlayerPosition());
		//print ("interval : " + interval);
		if ((interval/6.62f) < a) {
			if (inputresult.EndsWith ("0")) {
				str = "010";
			} else if (inputresult.EndsWith ("1")) {
				str = "011";
			}
		} else {
			if (inputresult.EndsWith ("0")) {
				str = "100";
			} else if (inputresult.EndsWith ("1")) {
				str = "101";
			}
		}
		print ("str : " + str);
		return str;
	}


	public void ActionDecision(string input,string selectAI){
		print ("input : " + input);

		//print ("*********************** " + animations);
		if (selectAI == "enemy") {
			animControl = GameObject.Find ("Animation1").GetComponent<AnimationController> ();
			charControl = GameObject.Find ("CharControl1").GetComponent<CharController> ();
		} else if(selectAI == "Player"){
			animControl = GameObject.Find ("Animation").GetComponent<AnimationController> ();
			charControl = GameObject.Find ("CharControl").GetComponent<CharController> ();
		}
		//animControl = animobj.GetComponent<AnimationController> ();
		//charControl = charobj.GetComponent<CharController> ();
		if (input == "100") {
			if(charControl.isGrounded){
				if(selectAI == "enemy"){
					charControl.moveAIEnemy ("approach", enemy_position, player_position);
				}else if(selectAI == "Player"){
					charControl.moveAIEnemy ("leave", enemy_position, player_position);
				}
			}
		} else if (input == "010") {
			if(charControl.isGrounded){
				if(selectAI == "enemy"){
					charControl.moveAIEnemy ("leave", enemy_position, player_position);
				}else if(selectAI == "Player"){
					charControl.moveAIEnemy ("approach", enemy_position, player_position);
				}
			}
		} else if (input == "001") {
			charControl.jumpAIEnemy();
		}else if (input == "10") {
			animControl.Punch_Anim();
		} else if (input == "01") {
			animControl.Kick_Anim();
		} else if (input == "1") {
			//charControl.guardAIEnemy();
		}


	}



	public float getEnemyPosition(){
		return enemy_position;
	}

	public float getPlayerPosition(){
		return player_position;
	}
}
