using UnityEngine;
using System.Collections;

public class LoopManagerController : MonoBehaviour {
	public CharController ch;
	public AnimationController anim;
	public ComandController cc;
	public GameObject ken;
	public Animator ken_anime;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		ch.Character_Loop ();
		/*if (ken_anime.GetCurrentAnimatorStateInfo (0).IsTag ("state")) {
			ch.Character_Loop ();
		} else {
			print("OKKKK " );
		}*/
		anim.Animation_Loop ();
		cc.Comand_Loop ();
	}
}
