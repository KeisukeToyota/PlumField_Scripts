using UnityEngine;
using System.Collections;
using System.Text.RegularExpressions;
public class AnimationController : MonoBehaviour {

	public bool walk_flag = false;
	public int step_speed;
	bool crouch_flag = false;
	private Vector3 ken_localscale_x;
	public Transform ken_transform;
	public ComandController cm;

	public CharacterInfomations charinfo;
	public bool damage_reduction_flag = false;

	public Animation anime;
	public CharController ch;
	public Rigidbody rb;
	public Rigidbody another_rb;
	public GameObject ccontroller_obj;
	public GameObject ken_animator;
	public Animator anim;
	public GameObject hadouken;
	public GameObject hadouken_obj;
	public GameObject charactorinfomation_obj;
	private string enemy_direction;
	private string player_direction;
	public AudioSource audiosource;
	public AnimatorStateInfo animinfo;
	public BoxCollision boxcollision;

	//private var judg;

	void Start (){
		//AudioSource audiosource = gameObject.GetComponent<AudioSource> ();
		ch = ccontroller_obj.GetComponent<CharController> ();
		anim = ken_animator.GetComponent<Animator> ();
		//judg = GetComponent<GameObject>().Find("enemy__judg");
	}
	void Update(){
		enemy_direction = charactorinfomation_obj.GetComponent<CharacterInfomations> ().enemy_direction;
		player_direction = charactorinfomation_obj.GetComponent<CharacterInfomations> ().enemy_direction;
		//MoveProcess ();
		///print ("waza_flag : " + waza_flag);

		animinfo = anim.GetCurrentAnimatorStateInfo(0);

		// if (animinfo.normalizedTime < 1.0f) {
		// 	ch.OpenFreeze();
		// }
		// if (anim.GetCurrentAnimatorStateInfo (0).IsName ("hit_body")) {
		// 	//charinfo.guard_flag = true;
		// 	ch.DamegeFreeze();
		// }

		StayForcing ();

		//print ("charinfo.attack_flag : " + charinfo.attack_flag);



		// if (charinfo.possible_trick == true){
		// 	anim.SetBool("isStandPunch",false);
		// 	anim.SetBool("isStandKick",false);
		// 	anim.SetBool("isJump",false);
		// 	anim.SetBool("isWalk_foward",false);
		// 	anim.SetBool("isHadouken",false);
		// 	anim.SetBool("isShoryuuken",false);
		// }

	}
	void FixedUpdate () {
		/*
		Place ();
		Crouch_Anim ();
		Anim();
		*/

	}

	/*void OnCollisionEnter (Collision col){
		if (col.gameObject.tag == "Wall") {
			rb.velocity = new Vector2(rb.velocity.x,rb.velocity.y);
		}
		if (col.gameObject.tag == "Ground") {
			ch.isGrounded = true;
		}
	}*/

	public void BoolManeger(){

		//jude.active = false;

		if(anim.GetCurrentAnimatorStateInfo (0).IsName ("Punch")){
			anim.SetBool("isStandPunch",false);
		}

		if(anim.GetCurrentAnimatorStateInfo (0).IsName ("Hadouken")){
			anim.SetBool("isHadouken",false);
		}


		if(anim.GetCurrentAnimatorStateInfo (0).IsName ("Kick")){
			anim.SetBool("isStandKick",false);
		}

		if(anim.GetCurrentAnimatorStateInfo (0).IsName ("walk_foward")){
			anim.SetBool("isWalk_foward",false);
		}

		if(anim.GetCurrentAnimatorStateInfo (0).IsName ("shoryuken")){
			anim.SetBool("isShoryuuken",false);
		}

		if(anim.GetCurrentAnimatorStateInfo (0).IsName ("Idle") || anim.GetCurrentAnimatorStateInfo (0).IsName ("walk_foward") || anim.GetCurrentAnimatorStateInfo (0).IsName ("jump")){
			charinfo.attack_flag = false;
		}else{
			charinfo.attack_flag = true;
		}



	}

	public void StayForcing(){
		if(animinfo.normalizedTime < 1.0f){
			//anim.SetTrigger("Idle");


			//anim.SetBool("isGuard",false);
		}
	}

	public void Punch_Anim(){
		if (anim.GetCurrentAnimatorStateInfo (0).IsTag ("trick") != true) {
			charinfo.possible_trick = true;
			anim.SetBool ("isStandPunch", true);
			charinfo.attack_flag = true;
		}
		// if(anim.GetCurrentAnimatorStateInfo (0).IsName ("punch01")){
		// 	anim.SetBool("isStandPunch",false);
		// }
	}

	public void Rising_P_Anim(){
		if (anim.GetCurrentAnimatorStateInfo (0).IsTag ("trick") != true) {
			charinfo.possible_trick = true;
			anim.SetBool("isShoryuuken",true);
			charinfo.attack_flag = true;
		}
	}

	public void Somersault_Anim(){
		if (anim.GetCurrentAnimatorStateInfo (0).IsTag ("trick") != true) {
			charinfo.possible_trick = true;
			anim.SetTrigger("SAMK");
		}
	}

	public void Kick_Anim(){
		if (anim.GetCurrentAnimatorStateInfo (0).IsTag ("trick") != true) {
			charinfo.possible_trick = true;
			boxcollision.judg.SetActive(true);
			boxcollision.enemy_judg.SetActive(true);
			anim.SetBool("isStandKick", true);
			charinfo.attack_flag = true;
		}
		// if(anim.GetCurrentAnimatorStateInfo (0).IsName ("kick01")){
		// 	anim.SetBool("isStandKick",false);
		// }
	}

	public void Guard_Anim(){
		if (anim.GetCurrentAnimatorStateInfo (0).IsTag ("trick") != true && Input.GetKey ("c") ){
			charinfo.possible_trick = true;
			charinfo.guard_flag = true;
			anim.SetBool("isGuard",true);
		}else if(Input.GetKeyUp("c")){
			charinfo.guard_flag = false;
			anim.SetBool("isGuard",false);
		}
	}

	/*public void EnemyGuardAnim(){
		if (anim.GetCurrentAnimatorStateInfo (0).IsTag ("trick") != true){
			//charinfo.possible_trick = true;
			charinfo.guard_flag = true;
			anim.SetBool("isGuard",true);
		}else{
			charinfo.guard_flag = false;
			anim.SetBool("isGuard",false);
		}
	}*/


	public void Walk_Anim(){
	//if (ken_animator.tag != "jumplast") {
		// if (charinfo.attack_flag == false) {
		// 	if (walk_flag) {
		// 		if (Input.GetKey ("right") || Input.GetKey ("left")) {
		//
		// 		} else {
		// 			//print("o");
		// 			walk_flag = false;
		// 			//anim.SetBool ("isWalk_foward", false);
		// 			anim.SetTrigger("isWalk");
		// 			//anim.SetBool("idle",true);
		// 			//anim.SetTrigger ("stay");
		// 		}
		// 	} else {
		// 		if (Input.GetKey ("right") || Input.GetKey ("left")) {
		// 			walk_flag = true;
		// 			//anim.SetBool ("isWalk_foward", true);
		// 			anim.SetTrigger ("isWalk");
		// 		}
		// 	}

				if (Input.GetKey ("right") || Input.GetKey ("left")) {
					//print("o");
					walk_flag = true;
					anim.SetBool ("isWalk_foward", true);
					//anim.SetTrigger("isWalk");
					//anim.SetBool("idle",true);
					//anim.SetTrigger ("stay");
				}else {
					walk_flag = false;
					anim.SetBool ("isWalk_foward", false);
					//anim.SetTrigger ("isWalk");
		}

		if(Input.GetKeyUp ("right") || Input.GetKeyUp ("left")){

		}
		//anim.SetTrigger("notIsWalk");
		// if(anim.GetCurrentAnimatorStateInfo (0).IsName ("walk_foward")){
		// 	anim.SetBool("isWalk_foward",false);
		// }
	}
	//}

	public void EnemyWalk_Anim(){
		anim.SetBool("isWalk_foward",true);
	}

	public void Jump_Anim (){
		if (anim.GetCurrentAnimatorStateInfo (0).IsTag ("trick") != true) {
			charinfo.possible_trick = true;
			anim.SetBool ("isJump", true);
		}

	}

	/*public void Crouch_Anim(){
		if (crouch_flag) {
			if (Input.GetKey ("down")) {
			} else {
				crouch_flag = false;
				anim.SetTrigger ("stay");
			}
		} else {
			if (Input.GetKey ("down")) {
				crouch_flag = true;
				anim.SetTrigger ("isCrouch");
			}
		}
	}*/



	public void Enemy_Hadooken (){
		if (anim.GetCurrentAnimatorStateInfo (0).IsTag ("trick") != true) {
			if (ch.isGrounded == true) {
				//audiosource.Play ();
				anim.SetBool("isHadouken",true);
				GameObject hdk = null;

				if (enemy_direction == "right") {
				//	hdk = Instantiate (hadouken, hadouken_obj.GetComponent<Transform> ().position , GetComponent<Transform> ().transform.rotation) as GameObject;
				StartCoroutine("sleep");
				//Instantiate(hadouken, hadouken_obj.GetComponent<Transform> ().position, GetComponent<Transform> ().transform.rotation);
				} else if (enemy_direction == "left") {
				//	hdk = Instantiate (hadouken, hadouken_obj.GetComponent<Transform> ().position , GetComponent<Transform> ().transform.rotation) as GameObject;
				StartCoroutine("sleep");
				//Instantiate(hadouken, hadouken_obj.GetComponent<Transform> ().position, GetComponent<Transform> ().transform.rotation);
				}

				// HadoukenControl hc = hdk.GetComponent<HadoukenControl> ();
				// hc.Enemy_Hadouken_Scale (enemy_direction);
			}
		}

	}

	public void Hadooken (){
		if (anim.GetCurrentAnimatorStateInfo (0).IsTag ("trick") != true) {
			if (ch.isGrounded == true) {
					if(anim.GetCurrentAnimatorStateInfo (0).IsTag ("trick") != true){
						anim.SetBool("isHadouken",true);
						if(anim.GetBool("isHadouken") == true){

							//anim.SetTrigger ("isHadooken");
							print (anim.GetBool("isHadouken"));

							GameObject hdk = null;
							if (player_direction == "right") {
								//hdk = Instantiate (hadouken, hadouken_obj.GetComponent<Transform> ().position, GetComponent<Transform> ().transform.rotation) as GameObject;
								StartCoroutine("sleep");
							} else if (player_direction == "left") {
								//hdk = Instantiate (hadouken, hadouken_obj.GetComponent<Transform> ().position, GetComponent<Transform> ().transform.rotation) as GameObject;
								StartCoroutine("sleep");
								//Instantiate(hadouken, hadouken_obj.GetComponent<Transform> ().position, GetComponent<Transform> ().transform.rotation);
							}
							// HadoukenControl hc = hdk.GetComponent<HadoukenControl> ();
							// hc.Player_Hadouken_Scale (player_direction);
					}
				}
			}

		}
	}

	IEnumerator sleep(){
     yield return new WaitForSeconds(1);
		 audiosource.Play ();
		 Instantiate(hadouken, hadouken_obj.GetComponent<Transform> ().position, GetComponent<Transform> ().transform.rotation);
	 }


	public void Destroy() {
		Destroy(this.gameObject);
	}

	public void Anim (){
		//velY:y方向へかかる速度単位,上へいくとプラス、下へいくとマイナス
		float velY = rb.velocity.y;
		//print (velY);

		//Animatorへパラメーターを送る
		//anim.SetBool("isGrounded",ch.isGrounded);
		//anim.SetFloat("velY",velY);
	}

	public void Place(){
		//float x = Input.GetAxisRaw ("Horizontal");
		//ken_localscale_x = ken_transform.localScale;
		if (cm.Ken_position < cm.Enemy_position) {
			//ken_localscale_x = transform.Rotate(new Vector3(0, 1, 0), 90);
			ken_transform.rotation  = Quaternion.Euler(0, 0, 0);
		} else {
			//ken_localscale_x = transform.Rotate(new Vector3(0, 1, 0), -90);
			ken_transform.rotation  = Quaternion.Euler(0, 180, 0);
		}
		//ken_transform.localScale = transform.localScale = ken_localscale_x;
	}

	/*public void Enemy_Place(){
		//ken_localscale_x = ken_transform.localScale;
		if (cm.Ken_position > cm.Enemy_position) {
			//ken_localscale_x.x = 1;
			print ("right");
			ken_transform.rotation  = Quaternion.Euler(0, -90, 0);
		} else {
			//ken_localscale_x.x = -1;
			print ("left");
			ken_transform.rotation  = Quaternion.Euler(0, 90, 0);
		}
		//ken_transform.localScale = transform.localScale = ken_localscale_x;
	}*/




	public void Step_Foward_Anim(){
		if (anim.GetCurrentAnimatorStateInfo (0).IsTag ("trick") != true) {
			charinfo.possible_trick = true;
			anim.SetBool ("isStep_foward",true);
			float x = Input.GetAxisRaw ("Horizontal");
			rb.velocity = new Vector2 (x * step_speed, rb.velocity.y);
		}

	}

	public void Step_Back_Anim(){
		if (anim.GetCurrentAnimatorStateInfo (0).IsTag ("trick") != true) {
			charinfo.possible_trick = true;
			anim.SetBool ("isStep_back",true);
			float x = Input.GetAxisRaw ("Horizontal");
			rb.velocity = new Vector2 (x * step_speed, rb.velocity.y);
		}
	}

	public void Body_Damage(){
		//if (charinfo.damege_flag == false) {
		/*if (cm.Ken_position < cm.Enemy_position) {
			rb.AddForce (new Vector3 (-100, 0, 0));
			another_rb.AddForce (new Vector3 (100, 0, 0));
		} else {
			rb.AddForce(new Vector3(100,0,0));
			another_rb.AddForce (new Vector3 (-100, 0, 0));
		}*/
		anim.SetTrigger ("body_damege");
			//charinfo.damege_flag = true;
		//}
	}

	public void Possible(){
		if (anim.GetCurrentAnimatorStateInfo (0).IsName ("Idle") || anim.GetCurrentAnimatorStateInfo (0).IsName ("walk_foward")) {
			charinfo.possible_trick = false;
			charinfo.guard_flag = false;
			//charinfo.attack_flag = false;
			//charinfo.damege_flag = false;
		}else{
			charinfo.possible_trick = true;
			//charinfo.damege_flag = true;
		}
		if(anim.GetBool("isGuard") == true){
			charinfo.possible_trick = true;
			//charinfo.damege_flag = true;
		}
	}



	public void Animation_Loop(){
		Place ();
		//Crouch_Anim ();
		Anim();
		Guard_Anim ();
		Possible ();
		BoolManeger();
		//Walk_Anim();

	}


}
