using UnityEngine;
using System.Collections;

public class characterController : MonoBehaviour {
	/*Rigidbody rb;
	int moveSpeed = 5;
	float jumpForce = 300;
	bool isGrounded;
	bool walk_flag = false;
	Vector3 theScale;
	//public int hp = 100;




	void Start (){
		rb = GetComponent<Rigidbody>();
		theScale = transform.localScale;
	}

	void FixedUpdate () {
		rb.velocity = Vector2.zero;


		//print (hp);
		//Jump();
		//Walk ();
		//アニメーション用管理メソッドへ
		Anim();
	}

	void OnCollisionEnter (Collision col){

		if (col.gameObject.tag == "Wall") {
			//rb.velocity = new Vector2(rb.velocity.x,rb.velocity.y);
		}
		if (col.gameObject.tag == "Ground") {
			isGrounded = true;
		}
	}

	void OnCollisionStay(Collision col){
		//float x = transform.position.x;
		if (col.gameObject.tag == "Player") {
			transform.Translate(0f,0f,0f);
		}
	}
	

	void Jump (){
		if (isGrounded && Input.GetButtonDown ("Jump")) {

			isGrounded = false;
			//Jumpトリガーを実行し、アニメーションの開始
			GetComponent<Animator> ().SetTrigger ("Jump");
			rb.AddForce (Vector2.up * jumpForce);
		} else if (isGrounded != true) {
			AddPowerSet();
		}
	}

	void Walk(){
		if (walk_flag ) {
			if (Input.GetKey ("right") || Input.GetKey ("left")) {
			}else{
				walk_flag = false;
				GetComponent<Animator> ().SetTrigger ("stay");
			}
			AddPowerSet();
		} else {
			if (Input.GetKey ("right") || Input.GetKey ("left")) {
				walk_flag = true;
				GetComponent<Animator> ().SetTrigger ("isWalk");
				if(Input.GetKey ("left")){
					theScale.x = -1;
					transform.localScale = theScale;
				}else{
					theScale.x = 1;
					transform.localScale = theScale;
				}
			}
		}
	}
	
	public void Destroy() {
		Destroy(this.gameObject);
	}
	
	void Anim (){
		//velY:y方向へかかる速度単位,上へいくとプラス、下へいくとマイナス
		float velY = rb.velocity.y;
		//Animatorへパラメーターを送る
		this.GetComponent<Animator>().SetBool("isGrounded",isGrounded);
		this.GetComponent<Animator>().SetFloat("velY",velY);
	}

	void AddPowerSet(){
		float x = Input.GetAxisRaw ("Horizontal");
		if (isGrounded) {
			if (transform.localScale.x == -1) {
				rb.velocity = new Vector2 (transform.localScale.x * moveSpeed * x * -1, rb.velocity.y);
			} else {
				rb.velocity = new Vector2 (transform.localScale.x * moveSpeed * x, rb.velocity.y);
			}
		} else {
			if (x == 0) {
			} else {
				rb.velocity = new Vector2 (transform.localScale.x * moveSpeed , rb.velocity.y);
			}
		}

	}

*/
}