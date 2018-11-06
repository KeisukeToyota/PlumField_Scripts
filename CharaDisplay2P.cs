using UnityEngine;
using System.Collections;

public class CharaDisplay2P : MonoBehaviour {
	
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
	private GameObject enemy1;
	private GameObject enemy2;
	private GameObject enemy3;
	private GameObject enemy4;
	private GameObject enemy5;
	private GameObject enemy6;
	private GameObject enemy7;
	private GameObject enemy8;
	private GameObject enemy9;
	private GameObject enemy10;
	int x;
	
	// Use this for initialization
	void Start () {
		x = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			x = x+1;
		}
		if (x > 1) {
			x=2;
			GetComponent<SelectCursor2P>().enabled = false;
		}
	}
	
	void OnTriggerEnter(Collider c){
		if (c.tag == "Chara1") { 
			Instantiate (Resources.Load ("Prefabs2/enemy"), new Vector3 (0f, 0f, -10f),Quaternion.identity);
			Instantiate (Resources.Load ("CharaDisp2/EnemyDisp 1"), new Vector3 (4.5f, 0.8f, 40.7f), Quaternion.identity);
			Debug.Log ("Chara1");
		} else {
			chara1=GameObject.Find ("enemy(Clone)");
			GameObject.Destroy (chara1);
			enemy1=GameObject.Find ("EnemyDisp 1(Clone)");
			GameObject.Destroy (enemy1);
		}
		if (c.tag == "Chara2") { 
			Instantiate (Resources.Load ("Prefabs2/enemy 2"), new Vector3 (0f, 0f, -10f), Quaternion.identity);
			Instantiate (Resources.Load ("CharaDisp2/EnemyDisp 2"), new Vector3 (4.5f, 0.8f, 40.7f),Quaternion.identity);
			Debug.Log ("Chara2");
		} else {
			chara2=GameObject.Find ("enemy 2(Clone)");
			GameObject.Destroy (chara2);
			enemy2=GameObject.Find ("EnemyDisp 2(Clone)");
			GameObject.Destroy (enemy2);
		}
		if (c.tag == "Chara3") { 
			Instantiate (Resources.Load ("Prefabs2/enemy 3"), new Vector3 (0f, 0f, -10f), Quaternion.identity);
			Instantiate (Resources.Load ("CharaDisp2/EnemyDisp 3"), new Vector3 (4.5f, 0.8f, 40.7f),Quaternion.identity);
			Debug.Log ("Chara3");
		} else {
			chara3=GameObject.Find ("enemy 3(Clone)");
			GameObject.Destroy (chara3);
			enemy3=GameObject.Find ("EnemyDisp 3(Clone)");
			GameObject.Destroy (enemy3);
		}
		if (c.tag == "Chara4") { 
			Instantiate (Resources.Load ("Prefabs2/enemy 4"), new Vector3 (0f, 0f, -10f), Quaternion.identity);
			Instantiate (Resources.Load ("CharaDisp2/EnemyDisp 4"), new Vector3 (4.5f, 0.8f, 40.7f),Quaternion.identity);
			Debug.Log ("Chara4");
		} else {
			chara4=GameObject.Find ("enemy 4(Clone)");
			GameObject.Destroy (chara4);
			enemy4=GameObject.Find ("EnemyDisp 4(Clone)");
			GameObject.Destroy (enemy4);
		}
		if (c.tag == "Chara5") { 
			Instantiate (Resources.Load ("Prefabs2/enemy 5"), new Vector3 (0f, 0f, -10f), Quaternion.identity);
			Instantiate (Resources.Load ("CharaDisp2/EnemyDisp 5"), new Vector3 (4.5f, 0.8f, 40.7f),Quaternion.identity);
			Debug.Log ("Chara5");
		} else {
			chara5=GameObject.Find ("enemy 5(Clone)");
			GameObject.Destroy (chara5);
			enemy5=GameObject.Find ("EnemyDisp 5(Clone)");
			GameObject.Destroy (enemy5);
		}
		if (c.tag == "Chara6") { 
			Instantiate (Resources.Load ("Prefabs2/enemy 6"), new Vector3 (0f, 0f, -10f), Quaternion.identity);
			Instantiate (Resources.Load ("CharaDisp2/EnemyDisp 6"), new Vector3 (4.5f, 0.8f, 40.7f),Quaternion.identity);
			Debug.Log ("Chara6");
		} else {
			chara6=GameObject.Find ("enemy 6(Clone)");
			GameObject.Destroy (chara6);
			enemy6=GameObject.Find ("EnemyDisp 6(Clone)");
			GameObject.Destroy (enemy6);
		}
		if (c.tag == "Chara7") { 
			Instantiate (Resources.Load ("Prefabs2/enemy 7"), new Vector3 (0f, 0f, -10f), Quaternion.identity);
			Instantiate (Resources.Load ("CharaDisp2/EnemyDisp 7"), new Vector3 (4.5f, 0.8f, 40.7f),Quaternion.identity);
			Debug.Log ("Chara7");
		} else {
			chara7=GameObject.Find ("enemy 7(Clone)");
			GameObject.Destroy (chara7);
			enemy7=GameObject.Find ("EnemyDisp 7(Clone)");
			GameObject.Destroy (enemy7);
		}
		if (c.tag == "Chara8") { 
			Instantiate (Resources.Load ("Prefabs2/enemy 8"), new Vector3 (0f, 0f, -10f), Quaternion.identity);
			Instantiate (Resources.Load ("CharaDisp2/EnemyDisp 8"), new Vector3 (4.5f, 0.8f, 40.7f),Quaternion.identity);
			Debug.Log ("Chara8");
		} else {
			chara8=GameObject.Find ("enemy 8(Clone)");
			GameObject.Destroy (chara8);
			enemy8=GameObject.Find ("EnemyDisp 8(Clone)");
			GameObject.Destroy (enemy8);
		}
		if (c.tag == "Chara9") { 
			Instantiate (Resources.Load ("Prefabs2/enemy 9"), new Vector3 (0f, 0f, -10f), Quaternion.identity);
			Instantiate (Resources.Load ("CharaDisp2/EnemyDisp 9"), new Vector3 (4.5f, 0.8f, 40.7f),Quaternion.identity);
			Debug.Log ("Chara9");
		} else {
			chara9=GameObject.Find ("enemy 9(Clone)");
			GameObject.Destroy (chara9);
			enemy9=GameObject.Find ("EnemyDisp 9(Clone)");
			GameObject.Destroy (enemy9);
		}
		if (c.tag == "Chara10") { 
			Instantiate (Resources.Load ("Prefabs2/enemy 10"), new Vector3 (0f, 0f, -10f), Quaternion.identity);
			Instantiate (Resources.Load ("CharaDisp2/EnemyDisp 10"), new Vector3 (4.5f, 0.8f, 40.7f),Quaternion.identity);
			Debug.Log ("Chara10");
		} else {
			chara10=GameObject.Find ("enemy 10(Clone)");
			GameObject.Destroy (chara10);
			enemy10=GameObject.Find ("EnemyDisp 10(Clone)");
			GameObject.Destroy (enemy10);
		}
	}
}
