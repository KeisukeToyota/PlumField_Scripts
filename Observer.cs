using UnityEngine;
using System.IO;
using System.Text;
using System.Collections;

public class Observer : MonoBehaviour {

	public InputData inputdata;
	public InputEnemyData inputenemydata;
	public Animator player_anim;
	public Animator enemy_anim;
	public ComandController comandcontrol;
	public CharacterInfomations playerinfo;
	public CharacterInfomations enemyinfo;
	public string output_data;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void FixedUpdate () {
		//PlayerData ();
		EnemyData ();
	}

	public void PlayerData(){
		Encoding encoding = Encoding.GetEncoding("Shift_JIS");
		StreamWriter w_dicision = new StreamWriter("dicision.txt",true,encoding);
		StreamWriter w_attack = new StreamWriter("attack.txt",true,encoding);
		StreamWriter w_defense = new StreamWriter("defense.txt",true,encoding);
		//StreamWriter testwrite = new StreamWriter ("/Users/toyotakeisuke/Documents/PlumField/Assets/Script/testtest.txt",true,encoding);
		//int sum = move + attack + guard + stay;
		//write.WriteLine ("sum " + sum);

		if (player_anim.GetCurrentAnimatorStateInfo (0).IsName ("walk_foward") == true || player_anim.GetCurrentAnimatorStateInfo (0).IsName ("jump") == true) {
			//move += 1;
			//w_dicision.WriteLine (inputdata.WalkDecision() + inputdata.JumpDecision()  );
			w_dicision.WriteLine (Mathf.Abs ((comandcontrol.Ken_position - comandcontrol.Enemy_position) / 6.62f) + inputdata.JumpDecision ());
			w_attack.WriteLine (inputdata.AttackDecision ());
			w_defense.WriteLine (inputdata.DefenseDecision ());
			w_dicision.Close ();
			w_attack.Close ();
			w_defense.Close ();

		} else if (player_anim.GetCurrentAnimatorStateInfo (0).IsName ("punch01") || player_anim.GetCurrentAnimatorStateInfo (0).IsName ("punch02") || player_anim.GetCurrentAnimatorStateInfo (0).IsName ("punch03") || player_anim.GetCurrentAnimatorStateInfo (0).IsName ("kick01") || player_anim.GetCurrentAnimatorStateInfo (0).IsName ("kick02") || player_anim.GetCurrentAnimatorStateInfo (0).IsName ("kick03")) {
			//attack += 1;
			//w_dicision.WriteLine (inputdata.WalkDecision() + inputdata.JumpDecision() );
			w_dicision.WriteLine (Mathf.Abs ((comandcontrol.Ken_position - comandcontrol.Enemy_position) / 6.62f) + inputdata.JumpDecision ());
			w_attack.WriteLine (inputdata.AttackDecision ());
			w_defense.WriteLine (inputdata.DefenseDecision ());
			w_dicision.Close ();
			w_attack.Close ();
			w_defense.Close ();
		} else if (player_anim.GetCurrentAnimatorStateInfo (0).IsName ("guard") == true) {
			//guard += 1;
			//w_dicision.WriteLine (inputdata.WalkDecision() + inputdata.JumpDecision() );
			w_dicision.WriteLine (Mathf.Abs ((comandcontrol.Ken_position - comandcontrol.Enemy_position) / 6.62f) + inputdata.JumpDecision ());
			w_attack.WriteLine (inputdata.AttackDecision ());
			w_defense.WriteLine (inputdata.DefenseDecision ());
			w_dicision.Close ();
			w_attack.Close ();
			w_defense.Close ();
		} else if (player_anim.GetCurrentAnimatorStateInfo (0).IsName ("Idle") == true || player_anim.GetCurrentAnimatorStateInfo (0).IsName ("hit_body") == true) {
			//stay += 1;
			//w_dicision.WriteLine (inputdata.WalkDecision() + inputdata.JumpDecision() );
			w_dicision.WriteLine (Mathf.Abs ((comandcontrol.Ken_position - comandcontrol.Enemy_position) / 6.62f) + inputdata.JumpDecision ());
			w_attack.WriteLine (inputdata.AttackDecision ());
			w_defense.WriteLine (inputdata.DefenseDecision ());
			w_dicision.Close ();
			w_attack.Close ();
			w_defense.Close ();
		}

		/*int sum = move + attack + guard + stay;
		print "move" + move/sum;
		print "attack" + attack/sum;
		print "guard" + guard/sum;
		print "stay" + stay/sum;*/


	}


	public void EnemyData(){
		//Encoding encoding = Encoding.GetEncoding ("Shift_JIS");
		//StreamWriter write = new StreamWriter ("inputenemydata1.txt", true, encoding);

		if (enemy_anim.GetCurrentAnimatorStateInfo (0).IsName ("walk_foward") == true || enemy_anim.GetCurrentAnimatorStateInfo (0).IsName ("jump") == true) {
			//move += 1;
			//write.WriteLine (inputenemydata.WalkDecision() + inputenemydata.JumpDecision() + inputenemydata.AttackDecision() + inputenemydata.DefenseDecision() + Mathf.Abs((comandcontrol.Ken_position - comandcontrol.Enemy_position)/6.62f)+ " " + playerinfo.hp + " " + enemyinfo.hp );
			//write.Close ();
			output_data = inputenemydata.WalkDecision() + inputenemydata.JumpDecision() + inputenemydata.AttackDecision() + inputenemydata.DefenseDecision() + Mathf.Abs((comandcontrol.Ken_position - comandcontrol.Enemy_position)/6.62f)+ " " + playerinfo.hp + " " + enemyinfo.hp;

		} else if (enemy_anim.GetCurrentAnimatorStateInfo (0).IsName ("Punch") || enemy_anim.GetCurrentAnimatorStateInfo (0).IsName ("Kick")) {
			//attack += 1;
			//write.WriteLine (inputenemydata.WalkDecision() + inputenemydata.JumpDecision() + inputenemydata.AttackDecision() + inputenemydata.DefenseDecision() + Mathf.Abs((comandcontrol.Ken_position - comandcontrol.Enemy_position)/6.62f) + " " + playerinfo.hp + " " + enemyinfo.hp );
			//write.Close ();
			output_data = inputenemydata.WalkDecision() + inputenemydata.JumpDecision() + inputenemydata.AttackDecision() + inputenemydata.DefenseDecision() + Mathf.Abs((comandcontrol.Ken_position - comandcontrol.Enemy_position)/6.62f)+ " " + playerinfo.hp + " " + enemyinfo.hp;

		}  else if (enemy_anim.GetCurrentAnimatorStateInfo (0).IsName ("guard") == true) {
			//guard += 1;
			//write.WriteLine (inputenemydata.WalkDecision() + inputenemydata.JumpDecision() + inputenemydata.AttackDecision() + inputenemydata.DefenseDecision() + Mathf.Abs((comandcontrol.Ken_position - comandcontrol.Enemy_position)/6.62f) + " " + playerinfo.hp + " " + enemyinfo.hp );
			//write.Close ();
			output_data = inputenemydata.WalkDecision() + inputenemydata.JumpDecision() + inputenemydata.AttackDecision() + inputenemydata.DefenseDecision() + Mathf.Abs((comandcontrol.Ken_position - comandcontrol.Enemy_position)/6.62f)+ " " + playerinfo.hp + " " + enemyinfo.hp;

		}else if (enemy_anim.GetCurrentAnimatorStateInfo (0).IsName ("Idle") == true || enemy_anim.GetCurrentAnimatorStateInfo(0).IsName("hit_body") == true) {
			//stay += 1;
			//write.WriteLine (inputenemydata.WalkDecision() + inputenemydata.JumpDecision() + inputenemydata.AttackDecision() + inputenemydata.DefenseDecision() + Mathf.Abs((comandcontrol.Ken_position - comandcontrol.Enemy_position)/6.62f) + " " + playerinfo.hp + " " + enemyinfo.hp );
			//write.Close ();
			output_data = inputenemydata.WalkDecision() + inputenemydata.JumpDecision() + inputenemydata.AttackDecision() + inputenemydata.DefenseDecision() + Mathf.Abs((comandcontrol.Ken_position - comandcontrol.Enemy_position)/6.62f)+ " " + playerinfo.hp + " " + enemyinfo.hp;

		}
	}
}
