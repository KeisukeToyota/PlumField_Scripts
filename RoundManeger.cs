using UnityEngine;
using System.Collections;

public class RoundManeger : MonoBehaviour {

	public static int player_win;
	public static int enemy_win;
	public CharacterInfomations player_info;
	public CharacterInfomations enemy_info;
	public TimeCount timeCount;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void FixedUpdate () {
		//WinsCount ();
		// print ("player_win:" + player_win);
		// print ("enemy_win:" + enemy_win);
		// print ("player_hp:" + player_info.hp);
		// print ("enemy_hp:" + enemy_info.hp);



		if (Input.GetKey (KeyCode.Escape)) {
			player_win = 0;
			enemy_win = 0;
			Application.LoadLevel("Title01");
		}
		if (timeCount.timer <= 0) {

			if (Application.loadedLevelName == "vsCPU") {
				Application.LoadLevel("vsCPU");
			}else if(Application.loadedLevelName == "vsAI"){
				Application.LoadLevel("vsAI");
			}else if(Application.loadedLevelName == "AIvsCPU"){
				Application.LoadLevel("AIvsCPU");
			}

		}
		//print (timeCount.timer);
	}

	void Awake(){
		//DontDestroyOnLoad (this);
	}

	public int getPlayerWin(){
		return player_win;
	}

	public int getEnemyWin(){
		return enemy_win;
	}

	public void WinsCount(){
		if (player_info.hp <= 0) {
			enemy_win += 1;
		} else if (enemy_info.hp <= 0) {
			player_win += 1;
		}



		if(player_win == 1){
			if (Application.loadedLevelName == "vsCPU") {
				Application.LoadLevel("vsCPU");
			}else if(Application.loadedLevelName == "vsAI"){
				Application.LoadLevel("vsAI");
			}else if(Application.loadedLevelName == "AIvsCPU"){
				Application.LoadLevel("AIvsCPU");
			}
		}else if(enemy_win == 1){
			if (Application.loadedLevelName == "vsCPU") {
				Application.LoadLevel("vsCPU");
			}else if(Application.loadedLevelName == "vsAI"){
				Application.LoadLevel("vsAI");
			}else if(Application.loadedLevelName == "AIvsCPU"){
				Application.LoadLevel("AIvsCPU");
			}
		}

		if (player_win == 2) {
			player_win = 0;
			enemy_win = 0;
			Application.LoadLevel("Win");
		} else if (enemy_win == 2) {
			player_win = 0;
			enemy_win = 0;
			Application.LoadLevel("Lose");
		}

	}
}
