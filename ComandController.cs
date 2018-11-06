using UnityEngine;
using System.Collections;
using System.Text.RegularExpressions;

public class ComandController : MonoBehaviour {

	string inputCommands = "";
	bool commandEnable = true;

	int recCommandLength = 100;

	public bool attack_flag;

	public AnimationController ken_anime;
	//public characterController Enemy;

	public float Enemy_position;
	public float Ken_position;
	public GameObject enemy_obj;
	public Collider attack_collider;
	public GameObject characterinfo_obj;
	public CharacterInfomations characterinfo;
	public Animator player_animator;
	public GameObject player_obj;
	private bool trick_flag = false;
	public string[] trick_name_array;
	//public GameObject Hadouken;


	// Use this for initialization
	void Start () {
		player_animator = player_obj.GetComponent<Animator> ();
		characterinfo = characterinfo_obj.GetComponent<CharacterInfomations> ();
		//ken_anime = GetComponent<AnimationController> ();
		inputCommands = inputCommands.PadLeft(100);
		//StartCoroutine("commandInputControl");

	}



	// Update is called once per frame
	void Update () {
		//print (enemy_obj.name +" " + attack_flag);

		/*
		Enemy_position = enemy_obj.GetComponent<Transform>().position.x;
		Ken_position = GetComponent<Transform>().position.x;


		AnimatorStateInfo state =ken_anime.anim.GetCurrentAnimatorStateInfo (0);
		Enemy_position = enemy_obj.GetComponent<Transform>().position.x;
		Ken_position = GetComponent<Transform>().position.x;
		if(commandEnable){
			getAxis();
			getFire();
		}else{
			inputCommands += " ";
		}
		//confirmCommand();

		if (state.IsTag ("Hadooken_Attack") == true) {
			SetAttackBox ();
			//Debug.Log ("true!");
		} else if(state.IsTag ("Hadooken_Attack") == false){
			DeleteAttackBox ();
		}
		*/

	}

	/*IEnumerator commandInputControl(){

		while (true){
			//Axis
			if(commandEnable){
				getAxis();
				getFire();
			}else{
				inputCommands += " ";
			}

			confirmCommand();

			yield return null;
		}//end While
	}*/

	public void getAxis(){
		if(Input.GetAxisRaw("Vertical") > 0.9){
			if(Input.GetAxisRaw("Horizontal") > 0.9){inputCommands += "9";}
			else if (Input.GetAxisRaw("Horizontal") < -0.9){inputCommands += "7";}
			else if (Input.GetAxisRaw("Horizontal") == 0){inputCommands += "8";}
			else {inputCommands += "8";}
		}

		else if(Input.GetAxisRaw("Vertical") < -0.9){
			if(Input.GetAxisRaw("Horizontal") > 0.9){inputCommands += "3";}
			else if(Input.GetAxisRaw("Horizontal") < -0.9){inputCommands += "1";}
			else if(Input.GetAxisRaw("Horizontal") == 0){inputCommands += "2";}
			else {}
		}
		else if(Input.GetAxisRaw("Vertical") == 0){

			if(Input.GetAxisRaw("Horizontal") > 0.9){inputCommands += "6";}
			else if(Input.GetAxisRaw("Horizontal") < -0.9){inputCommands += "4";}
			else if(Input.GetAxisRaw("Horizontal") == 0){inputCommands += "5";}
			else {}
		}else{

		}

		if(inputCommands.Length > recCommandLength){
			inputCommands = inputCommands.Remove(0,1);
		}

	}

	void getFire(){
		//fire
		if(Input.GetKey(KeyCode.F) || Input.GetButton("Fire1")){
			inputCommands += "f";
		}
		if (Input.GetKeyDown (KeyCode.Z)) {
			inputCommands += "z";
		}
		if (Input.GetKeyDown (KeyCode.X)) {
			inputCommands += "x";
		}
		if (Input.GetKey (KeyCode.C)) {
			inputCommands += "c";
		}
		if (Input.GetKey (KeyCode.V)) {
			inputCommands += "v";
		}
		if(inputCommands.Length > recCommandLength){
			inputCommands = inputCommands.Remove(0,1);
		}
	}

	private void confirmCommand(){
		if (Ken_position - Enemy_position < 0) {
			string hadouken = "2{1,8}3{0,8}6{1,8}[z]";
			int comLength = 30;
			string checkframe = inputCommands.Remove (0, recCommandLength - comLength);
			if (Regex.IsMatch (checkframe, hadouken)) {
				ken_anime.Hadooken ();
				inputCommands = inputCommands.Replace("z","0");
				//Instantiate (Hadouken, transform.position, transform.rotation);
				Debug.Log ("HADOUKEN!");
				return;
			}

			/*string stepforward = "6{1,8}5{1,8}6{1,8}";
			comLength = 30;
			checkframe = inputCommands.Remove (0, recCommandLength - comLength);
			if (Regex.IsMatch (checkframe, stepforward)) {
				//Debug.Log ("SHINKU HADOUKEN!!!!");
				if(characterinfo.possible_trick == false){
					inputCommands = inputCommands.Replace("6","0");
					ken_anime.Step_Foward_Anim();
					print ("Step Forward!!");
					//player_animator.SetBool("isStep_foward",false);
				}
				return;
			}*/


			/*string stepback = "4{1,8}5{1,8}4{1,8}";
			comLength = 30;
			checkframe = inputCommands.Remove (0, recCommandLength - comLength);
			if (Regex.IsMatch (checkframe, stepback)) {
				//Debug.Log ("SHINKU HADOUKEN!!!!");
				if(characterinfo.possible_trick == false){
					inputCommands = inputCommands.Replace("4","0");
					ken_anime.Step_Back_Anim();
					print ("Step Back!!");
				}
				return;
			}*/



			/*string guard = "5{1,8}c";
			comLength = 30;
			checkframe = inputCommands.Remove (0, recCommandLength - comLength);
			if (Regex.IsMatch (checkframe, guard)) {
				//Debug.Log ("SHINKU HADOUKEN!!!!");
				if(characterinfo.possible_trick == false){
					//characterinfo.guard_flag = true;
					ken_anime.Guard_Anim();
					print ("Guard");
				}
				return;
			}*/

			string syagamiguard = "2{1,8}c";
			comLength = 30;
			checkframe = inputCommands.Remove (0, recCommandLength - comLength);
			if (Regex.IsMatch (checkframe, syagamiguard)) {
				//Debug.Log ("SHINKU HADOUKEN!!!!");
				if(characterinfo.possible_trick == false){
					inputCommands = inputCommands.Replace("c","0");
					print ("Guard");
				}
				return;
			}


			string syouryuu = "6{1,8}2{1,8}3{1,8}[z]";
			comLength = 30;
			checkframe = inputCommands.Remove (0, recCommandLength - comLength);
			if (Regex.IsMatch (checkframe, syouryuu)) {
				inputCommands = inputCommands.Replace("z","0");
				//ken_anime.Rising_P_Anim();
				print ("Syouryuuken!!!");
				return;
			}

			string somersault = "4{1,8}[x]";
			comLength = 30;
			checkframe = inputCommands.Remove (0, recCommandLength - comLength);
			if (Regex.IsMatch (checkframe, somersault)) {
				inputCommands = inputCommands.Replace("x","0");
				ken_anime.Somersault_Anim();
				print ("Somersault!!!");
				return;
			}

			string punch = "[456]{1,8}[z]";
			comLength = 50;
			checkframe = inputCommands.Remove (0, recCommandLength - comLength);
			if (Regex.IsMatch (checkframe, punch)) {
				inputCommands = inputCommands.Replace ("z", "0");
				ken_anime.Punch_Anim();
				Debug.Log ("Punch!!");
				return;
			}

			string kick = "[456]{1,8}[x]";
			comLength = 50;
			checkframe = inputCommands.Remove (0, recCommandLength - comLength);
			if (Regex.IsMatch (checkframe, kick)) {
				inputCommands = inputCommands.Replace("x","0");
				ken_anime.Kick_Anim();
				//Debug.Log ("Kick!!");
				return;
			}

			string crouch_punch = "[123]{1,8}[z]";
			comLength = 50;
			checkframe = inputCommands.Remove (0, recCommandLength - comLength);
			if (Regex.IsMatch (checkframe, crouch_punch)) {
				//Debug.Log ("Crouch Punch!!");
				return;
			}

			string crouch_kick = "[123]{1,8}[x]";
			comLength = 50;
			checkframe = inputCommands.Remove (0, recCommandLength - comLength);
			if (Regex.IsMatch (checkframe, crouch_kick)) {
				//Debug.Log ("Crouch Kick!!");
				return;
			}

			string jump = "8";
			comLength = 50;
			checkframe = inputCommands.Remove (0, recCommandLength - comLength);
			if (Regex.IsMatch (checkframe, jump)) {
				//Debug.Log ("Jump!!");
				return;
			}

			string crouch = "[123]";
			comLength = 50;
			checkframe = inputCommands.Remove (0, recCommandLength - comLength);
			if (Regex.IsMatch (checkframe, crouch)) {
				//Debug.Log ("Crouch!!");
				return;
			}
//			Debug.Log(checkframe);


		} else {
			//print ("test");
			string hadouken1 = "2{1,8}1{0,8}4{1,8}[z]";
			int comLength = 30;
			string checkframe = inputCommands.Remove (0, recCommandLength - comLength);
			if (Regex.IsMatch (checkframe, hadouken1)) {
				inputCommands = inputCommands.Replace("z","0");
				ken_anime.Hadooken ();

				Debug.Log ("HADOUKEN!");

				return;
			}

			/*string stepforward = "4{1,8}5{1,8}4{1,8}";
			comLength = 30;
			checkframe = inputCommands.Remove (0, recCommandLength - comLength);
			if (Regex.IsMatch (checkframe, stepforward)) {
				//Debug.Log ("SHINKU HADOUKEN!!!!");
				if(characterinfo.possible_trick == false){
					characterinfo.guard_flag = true;
					print ("Step Forward!!");
				}
				return;
			}


			string stepback = "6{1,8}5{1,8}6{1,8}";
			comLength = 30;
			checkframe = inputCommands.Remove (0, recCommandLength - comLength);
			if (Regex.IsMatch (checkframe, stepback)) {
				//Debug.Log ("SHINKU HADOUKEN!!!!");
				if(characterinfo.possible_trick == false){
					characterinfo.guard_flag = true;
					print ("Step Back!!");
				}
				return;
			}*/


			/*string guard = "5{1,8}c";
			comLength = 30;
			checkframe = inputCommands.Remove (0, recCommandLength - comLength);
			if (Regex.IsMatch (checkframe, guard)) {
				//Debug.Log ("SHINKU HADOUKEN!!!!");
				if(characterinfo.possible_trick == false){
					characterinfo.guard_flag = true;
					ken_anime.Guard_Anim();
					print ("Guard");
				}
				return;
			}*/

			string syagamiguard = "2{1,8}c";
			comLength = 30;
			checkframe = inputCommands.Remove (0, recCommandLength - comLength);
			if (Regex.IsMatch (checkframe, syagamiguard)) {
				//Debug.Log ("SHINKU HADOUKEN!!!!");
				if(characterinfo.possible_trick == false){
					print ("Guard");
				}
				return;
			}

			string syouryuu = "4{1,8}2{1,8}1{1,8}[z]";
			comLength = 30;
			checkframe = inputCommands.Remove (0, recCommandLength - comLength);
			if (Regex.IsMatch (checkframe, syouryuu)) {
				inputCommands = inputCommands.Replace("z","0");
				//ken_anime.Rising_P_Anim();
				print ("Syouryuuken!!!");
				return;
			}

			string punch = "[456]{1,8}[z]";
			comLength = 50;
			checkframe = inputCommands.Remove (0, recCommandLength - comLength);
			if (Regex.IsMatch (checkframe, punch)) {
				inputCommands = inputCommands.Replace ("z", "0");
				ken_anime.Punch_Anim();
				//Debug.Log ("Punch!!");
				return;
			}

			string kick = "[456]{1,8}[x]";
			comLength = 50;
			checkframe = inputCommands.Remove (0, recCommandLength - comLength);
			if (Regex.IsMatch (checkframe, kick)) {
				inputCommands = inputCommands.Replace("x","0");
				ken_anime.Kick_Anim();
				//Debug.Log ("Kick!!");
				return;
			}

			string crouch_punch = "[123]{1,8}[z]";
			comLength = 50;
			checkframe = inputCommands.Remove (0, recCommandLength - comLength);
			if (Regex.IsMatch (checkframe, crouch_punch)) {
				//Debug.Log ("Crouch Punch!!");
				return;
			}

			string crouch_kick = "[123]{1,8}[x]";
			comLength = 50;
			checkframe = inputCommands.Remove (0, recCommandLength - comLength);
			if (Regex.IsMatch (checkframe, crouch_kick)) {
				//Debug.Log ("Crouch Kick!!");
				return;
			}

			string jump = "8";
			comLength = 50;
			checkframe = inputCommands.Remove (0, recCommandLength - comLength);
			if (Regex.IsMatch (checkframe, jump)) {
				//Debug.Log ("Jump!!");
				return;
			}

			string crouch = "[123]";
			comLength = 50;
			checkframe = inputCommands.Remove (0, recCommandLength - comLength);
			if (Regex.IsMatch (checkframe, crouch)) {
				//Debug.Log ("Crouch!!");
				return;
			}
			//Debug.Log(checkframe);

		}


	}

	void SetAttackBox(){
		//attack_collider.enabled = true;
	}

	void DeleteAttackBox(){
		//attack_collider.enabled = false;
	}

	public void Comand_Loop(){
		AnimatorStateInfo state =ken_anime.anim.GetCurrentAnimatorStateInfo (0);
		Enemy_position = enemy_obj.GetComponent<Transform>().position.x;
		Ken_position = GetComponent<Transform>().position.x;
		if(commandEnable){
			getAxis();
			getFire();
		}else{
			inputCommands += " ";
		}



		if (state.IsTag ("Hadooken_Attack") == true) {
			SetAttackBox ();
		//Debug.Log ("true!");
		} else if(state.IsTag ("Hadooken_Attack") == false){
			DeleteAttackBox ();
		}

		Trick_Cheak ();
		confirmCommand ();
	}

	public void Enemy_Comand_Loop(){
		AnimatorStateInfo state =ken_anime.anim.GetCurrentAnimatorStateInfo (0);
		Enemy_position = enemy_obj.GetComponent<Transform>().position.x;
		Ken_position = GetComponent<Transform>().position.x;
		/*if(commandEnable){
			getAxis();
			getFire();
		}else{
			inputCommands += " ";
		}*/

		Trick_Cheak ();
		//confirmCommand ();

	}

	public void Trick_Cheak(){
		if (player_animator.GetCurrentAnimatorStateInfo (0).IsTag ("trick")) {
			trick_flag = true;
			/*for(int num = 0;num < trick_name_array.Length;num++){
				player_animator.SetBool(trick_name_array[num].ToString(),false);
			}*/
			player_animator.SetBool("isStandPunch",false);
			player_animator.SetBool ("isStep_foward",false);
			player_animator.SetBool ("isStep_back",false);
			player_animator.SetBool ("isStandKick",false);
			player_animator.SetBool ("isJump",false);
			player_animator.SetBool ("isThrow_take", false);
			characterinfo.attack_flag = false;
			//player_animator.SetBool ("isGuard",false);


			//print("trick true");
		} else {
			//print("trick false");
			trick_flag = false;
		}
	}


}
