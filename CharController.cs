using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour {
	//private Rigidbody2D rb;
	public string enemy_direction;
	public Rigidbody rb;
	int moveSpeed = 3;
	public float jumpForce = 400;
	public bool isGrounded = true ;
	//private bool walk_flag = false;
	Vector3 theScale;
	public GameObject ken_obj;
	public GameObject enemy_obj;
	public AnimationController ken_anime;
	public CharacterInfomations charinfo;

	public float enemy_position;
	public float player_position;


	// Use this for initialization
	void Start () {
		//ken_tranform = ken_obj.GetComponent<Transform> ();
		//rb = ken_obj.GetComponent<Rigidbody2D> ();
		rb = ken_obj.GetComponent<Rigidbody> ();

	}

	// Update is called once per frame
	void Update () {
		//Guard ();
		enemy_position = enemy_obj.GetComponent<Transform>().position.x;
		player_position = ken_obj.GetComponent<Transform>().position.x;
		if (isGrounded == true && ken_anime.anim.GetCurrentAnimatorStateInfo(0).IsTag("jumplast") == true) {
			ken_anime.anim.SetTrigger ("stay");
		}
		rb.constraints = RigidbodyConstraints.FreezeRotation;
		rb.constraints = RigidbodyConstraints.FreezePositionZ;

	}

	public void DamegeFreeze(){
		rb.constraints = RigidbodyConstraints.FreezeAll;
	}

	public void OpenFreeze(){
		rb.constraints = RigidbodyConstraints.None;
		rb.constraints = RigidbodyConstraints.FreezePositionZ;
		rb.constraints = RigidbodyConstraints.FreezeRotation;
	}



	public void Walk(){
		float x = Input.GetAxisRaw ("Horizontal");
		if (charinfo.possible_trick == false) {
			if (isGrounded) {
				//ken_anime.Walk_Anim ();

				rb.velocity = new Vector2 (x * moveSpeed, rb.velocity.y);

			}/*else {
			if (x == 0) {
			} else {
				ken_anime.Walk_Anim();
				rb.velocity = new Vector2 (x * moveSpeed , rb.velocity.y);
			}
		}*/
		}

	}

	public void Jump(){
		if (isGrounded && Input.GetKeyDown ("up")) {
			isGrounded = false;
			ken_anime.Jump_Anim();
			rb.AddForce (Vector2.up * jumpForce);

		} else{


		}
	}



	public void Character_Loop(){

		Walk ();
		Jump ();
		ken_anime.Anim ();



		//Debug.Log (isGrounded);
	}

	public void moveAIEnemy(string dir,double edist,double pdist){
		ken_anime.EnemyWalk_Anim ();
		string direction = "";
		//print (edist + "   " + pdist);
		if (isGrounded) {
			if (dir == "approach") {
				if (edist - pdist < 0) {
					direction = "right";
				} else {
					direction = "left";
				}
			} else if (dir == "leave") {
				if (edist - pdist < 0) {
					direction = "left";
				} else {
					direction = "right";
				}
			}
			//print ("dir : " + direction);
			if (direction == "right") {
				rb.velocity = new Vector2 (moveSpeed, 0);
				ken_anime.EnemyWalk_Anim();
			} else if(direction == "left"){
				rb.velocity = new Vector2 (-moveSpeed, 0);
				ken_anime.EnemyWalk_Anim();
			}
		}
	}



	public void jumpAIEnemy(){
		if (isGrounded == true) {
			isGrounded = false;
			ken_anime.Jump_Anim ();
			rb.AddForce (Vector2.up * jumpForce);
		}
	}

	/*public void guardAIEnemy(){
		if (isGrounded == true) {
			ken_anime.EnemyGuardAnim();
			isGrounded = false;
		}
	}*/

	public float JumpDirection(){
		float vel = rb.velocity.y;
		return vel;
	}


	/*public void attackAIEnemy(){
		if (isGrounded == true) {
			ken_anime.Punch_Anim();
			ken_anime.Kick_Anim();
			ken_anime.Step_Foward_Anim()

			//print ("isGrounded : " + isGrounded);
			//ken_anime.Enemy_Hadooken ();
		}

	}*/

	/*public void Guard(){
		float x = Input.GetAxisRaw ("Horizontal");
		if (x == 1 && player_position - enemy_position > 0) {
			print (x + " : " + (player_position - enemy_position));
			print ("Guard");
		} else if (x == -1 && (player_position - enemy_position < 0)) {
			print (x);
			print ("Guard");
		}
	}*/



}
