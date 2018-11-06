using UnityEngine;
using System.Collections;

public class PictureAdjustManager : MonoBehaviour {
	public Rect texturePos;
	private Vector2 size;
	private GUITexture texture;
	private float xs = 100;
	void Start(){

	}
	void OnGUI(){
		size = new Vector2(Screen.width, Screen.height);
		texture = this.GetComponent<GUITexture>();
		texture.pixelInset = new Rect(Screen.width * texturePos.x / xs, Screen.height * texturePos.y / xs,
		                              Screen.width * (1-texturePos.width / xs), Screen.height * (1-texturePos.height / xs));

	}


}
