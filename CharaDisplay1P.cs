using UnityEngine;
using System.Collections;

public class CharaDisplay1P : MonoBehaviour {

	private GameObject chara1;
	private GameObject chara2;
	private GameObject chara3;
	private GameObject chara4;
	private GameObject chara5;
	private GameObject chara6;
	private GameObject chara7;
	private GameObject chara8;
	private GameObject chara9;
	private GameObject chara10;
	private GameObject player1;
	private GameObject player2;
	private GameObject player3;
	private GameObject player4;
	private GameObject player5;
	private GameObject player6;
	private GameObject player7;
	private GameObject player8;
	private GameObject player9;
	private GameObject player10;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			GetComponent<SelectCursor1P>().enabled = false;
		}
	
	}

	void OnTriggerEnter(Collider c){
		if (c.tag == "Chara1") { 
			Instantiate (Resources.Load ("Prefabs1/Player 1"), new Vector3 (0f, 0f, -10f), Quaternion.identity);
			Instantiate (Resources.Load ("CharaDisp1/PlayerDisp 1"), new Vector3 (5.5f, 0.8f, 40.7f), Quaternion.identity);
			Debug.Log ("Chara1");
				} else {
			chara1=GameObject.Find ("Player 1(Clone)");
			GameObject.Destroy (chara1);
			player1=GameObject.Find ("PlayerDisp 1(Clone)");
			GameObject.Destroy (player1);
		}
		if (c.tag == "Chara2") { 
			Instantiate (Resources.Load ("Prefabs1/Player 2"), new Vector3 (0f, 0f, -10f), Quaternion.identity);
			Instantiate (Resources.Load ("CharaDisp1/PlayerDisp 2"), new Vector3 (5.5f, 0.8f, 40.7f), Quaternion.identity);
			Debug.Log ("Chara2");
		} else {
			chara2=GameObject.Find ("Player 2(Clone)");
			GameObject.Destroy (chara2);
			player2=GameObject.Find ("PlayerDisp 2(Clone)");
			GameObject.Destroy (player2);
		}
		if (c.tag == "Chara3") { 
			Instantiate (Resources.Load ("Prefabs1/Player 3"), new Vector3 (0f, 0f, -10f), Quaternion.identity);
			Instantiate (Resources.Load ("CharaDisp1/PlayerDisp 3"), new Vector3 (5.5f, 0.8f, 40.7f), Quaternion.identity);
			Debug.Log ("Chara3");
		} else {
			chara3=GameObject.Find ("Player 3(Clone)");
			GameObject.Destroy (chara3);
			player3=GameObject.Find ("PlayerDisp 3(Clone)");
			GameObject.Destroy (player3);
		}
		if (c.tag == "Chara4") { 
			Instantiate (Resources.Load ("Prefabs1/Player 4"), new Vector3 (0f, 0f, -10f), Quaternion.identity);
			Instantiate (Resources.Load ("CharaDisp1/PlayerDisp 4"), new Vector3 (5.5f, 0.8f, 40.7f), Quaternion.identity);
			Debug.Log ("Chara4");
		} else {
			chara4=GameObject.Find ("Player 4(Clone)");
			GameObject.Destroy (chara4);
			player4=GameObject.Find ("PlayerDisp 4(Clone)");
			GameObject.Destroy (player4);
		}
		if (c.tag == "Chara5") { 
			Instantiate (Resources.Load ("Prefabs1/Player 5"), new Vector3 (0f, 0f, -10f), Quaternion.identity);
			Instantiate (Resources.Load ("CharaDisp1/PlayerDisp 5"), new Vector3 (5.5f, 0.8f, 40.7f), Quaternion.identity);
			Debug.Log ("Chara5");
		} else {
			chara5=GameObject.Find ("Player 5(Clone)");
			GameObject.Destroy (chara5);
			player5=GameObject.Find ("PlayerDisp 5(Clone)");
			GameObject.Destroy (player5);
		}
		if (c.tag == "Chara6") { 
			Instantiate (Resources.Load ("Prefabs1/Player 6"), new Vector3 (0f, 0f, -10f), Quaternion.identity);
			Instantiate (Resources.Load ("CharaDisp1/PlayerDisp 6"), new Vector3 (5.5f, 0.8f, 40.7f), Quaternion.identity);
			Debug.Log ("Chara6");
		} else {
			chara6=GameObject.Find ("Player 6(Clone)");
			GameObject.Destroy (chara6);
			player6=GameObject.Find ("PlayerDisp 6(Clone)");
			GameObject.Destroy (player6);
		}
		if (c.tag == "Chara7") { 
			Instantiate (Resources.Load ("Prefabs1/Player 7"), new Vector3 (0f, 0f, -10f), Quaternion.identity);
			Instantiate (Resources.Load ("CharaDisp1/PlayerDisp 7"), new Vector3 (5.5f, 0.8f, 40.7f), Quaternion.identity);
			Debug.Log ("Chara7");
		} else {
			chara7=GameObject.Find ("Player 7(Clone)");
			GameObject.Destroy (chara7);
			player7=GameObject.Find ("PlayerDisp 7(Clone)");
			GameObject.Destroy (player7);
		}
		if (c.tag == "Chara8") { 
			Instantiate (Resources.Load ("Prefabs1/Player 8"), new Vector3 (0f, 0f, -10f), Quaternion.identity);
			Instantiate (Resources.Load ("CharaDisp1/PlayerDisp 8"), new Vector3 (5.5f, 0.8f, 40.7f), Quaternion.identity);
			Debug.Log ("Chara8");
		} else {
			chara8=GameObject.Find ("Player 8(Clone)");
			GameObject.Destroy (chara8);
			player8=GameObject.Find ("PlayerDisp 8(Clone)");
			GameObject.Destroy (player8);
		}
		if (c.tag == "Chara9") { 
			Instantiate (Resources.Load ("Prefabs1/Player 9"), new Vector3 (0f, 0f, -10f), Quaternion.identity);
			Instantiate (Resources.Load ("CharaDisp1/PlayerDisp 9"), new Vector3 (5.5f, 0.8f, 40.7f), Quaternion.identity);
			Debug.Log ("Chara9");
		} else {
			chara9=GameObject.Find ("Player 9(Clone)");
			GameObject.Destroy (chara9);
			player9=GameObject.Find ("PlayerDisp 9(Clone)");
			GameObject.Destroy (player9);
		}
		if (c.tag == "Chara10") { 
			Instantiate (Resources.Load ("Prefabs1/Player 10"), new Vector3 (0f, 0f, -10f), Quaternion.identity);
			Instantiate (Resources.Load ("CharaDisp1/PlayerDisp 10"), new Vector3 (5.5f, 0.8f, 40.7f), Quaternion.identity);
			Debug.Log ("Chara10");
		} else {
			chara10=GameObject.Find ("Player 10(Clone)");
			GameObject.Destroy (chara10);
			player10=GameObject.Find ("PlayerDisp 10(Clone)");
			GameObject.Destroy (player10);
		}
	}
}
