using UnityEngine;
using System.Collections;

public class enemy_star_color : MonoBehaviour {
	public GameObject gauge;
	public Texture[] star;
	public Renderer rend_s1,rend_s2;
	private  int round;
	public HPbar hpbar;
	public RoundManeger rm;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Count ();
	}
	
	void Awake(){
		//DontDestroyOnLoad (this);
	}
	
	private  void Count(){
		//round = gauge.GetComponent<HPbar> ().getCount();
		//round = hpbar.getCount ();
		round = rm.getEnemyWin ();
		if (round == 1) {
			rend_s1.material.mainTexture = star [1];
		} else if (round == 2) {
			rend_s2.material.mainTexture = star [1];
		} else {
			rend_s1.material.mainTexture = star[0];
			rend_s2.material.mainTexture = star[0];
		}
		
		//Debug.Log (round);
	}
	
}