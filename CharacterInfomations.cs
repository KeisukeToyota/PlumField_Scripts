using UnityEngine;
using System.Collections;

public class CharacterInfomations : MonoBehaviour {
	public string enemy_direction;
	public string player_direction;
	public bool guard_flag = false;
	public bool possible_trick = false;
	public bool damege_flag = false;
	public bool attack_flag = false;

	//public bool animation_flag = false;

	//public float HP;
	public GameObject player_obj;
	public GameObject enemy_obj;
	public GameObject comand_obj;
	public Vector3 player_vec;
	public Vector3 enemy_vec;
	public Rigidbody enemy_rb;
	//public Vector3 dir;
	private ComandController comandcontrol;
	public Animator player_anime;
	public float hp = 1;
	public float dir;
	public RoundManeger rm;


	// Use this for initialization
	void Start () {
		player_anime = player_obj.GetComponent<Animator> ();

	}

	// Update is called once per frame
	void Update () {

		//float angleDir = transform.eulerAngles.z * (Mathf.PI / 180.0f);
		//dir = new Vector3 (Mathf.Cos (angleDir), Mathf.Sin (angleDir), 0.0f);
		dir = enemy_rb.velocity.x;

		//print ("dir : " + dir);

		//print ("GUARD_FLAG :" + guard_flag);
		//print (player_obj+ " " + hp);
		comandcontrol = comand_obj.GetComponent<ComandController> ();
		player_vec = player_obj.GetComponent<Transform> ().position;
		enemy_vec = enemy_obj.GetComponent<Transform> ().position;

		if (player_vec.x - enemy_vec.x > 0) {
			enemy_direction = "left";
		} else {
			enemy_direction = "right";
		}

		if (player_vec.x - enemy_vec.x > 0) {
			player_direction = "right";
		} else {
			player_direction = "left";
		}

		if (hp <= 0) {
			//print ("END");
			rm.WinsCount();
			Destroy(player_obj);
		}

	}





}
