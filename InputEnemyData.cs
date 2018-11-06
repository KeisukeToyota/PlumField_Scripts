using UnityEngine;
using System.Collections;
using System.Text;
using System.IO;

public class InputEnemyData : MonoBehaviour {
	public ComandController comandcontrol;
	public CharacterInfomations charinfomations;
	public CharController charcontroller;
	public AnimationController animationcontrol;
	public CharacterInfomations playerinfo;
	public CharacterInfomations enemyinfo;
	public Animator anim;
	//public int move=0,attack=0,guard=0,stay=0;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//data ();
		//print (charinfomations.dir);
	}

	public string WalkDecision(){
		if (comandcontrol.Ken_position < comandcontrol.Enemy_position) {
			if (charinfomations.dir > 0) {
				return "1 0 ";
			} else if (charinfomations.dir < 0) {
				return "0 1 ";
			}else{
				return "0 0 ";
			}
		} else if (comandcontrol.Ken_position > comandcontrol.Enemy_position) {
			if (charinfomations.dir > 0) {
				return "0 1 ";
			} else if (charinfomations.dir < 0) {
				return "1 0 ";
			}else{
				return "0 0 ";
			}
		}
		return "0 0 ";
	}


	public string JumpDecision(){
		if (charcontroller.JumpDirection() > 0) {
			return "1 ";
		} else {
			return "0 ";
		}
	}


	public string AttackDecision(){
		if (anim.GetCurrentAnimatorStateInfo (0).IsName ("Punch")) {
			return "1 0 ";
		} else if (anim.GetCurrentAnimatorStateInfo (0).IsName ("Kick")) {
			return "0 1 ";
		} else {
			return "0 0 ";
		}
	}

	public string DefenseDecision(){
		if (anim.GetCurrentAnimatorStateInfo (0).IsName ("guard")) {
			return "1 ";
		} else {
			return "0 ";
		}
	}





}
