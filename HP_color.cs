using UnityEngine;
using System.Collections;

public class HP_color : MonoBehaviour {
	public Texture[] textures;
	public GameObject gauge;
	public Renderer rend;
	private double HP;
	public CharacterInfomations charinfo;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		HP = gauge.transform.localScale.x;
		if (HP <= 1 && HP > 0.5) {
			rend.material.mainTexture = textures [0];
		} else if (HP <= 0.5 && HP > 0.2) {
			rend.material.mainTexture = textures [1];
		} else if (HP <= 0.2 && HP > 0.005) {
			rend.material.mainTexture = textures [2];
		} else {
			rend.material.mainTexture = textures [3];
		}
	}
}