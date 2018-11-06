using UnityEngine;
using System.Collections;

public class CountManager : MonoBehaviour {
	public Texture[] number_texture;
	public GUITexture One_obj;
	public GUITexture Ten_obj;
	public GameObject time_obj;
	public int num1 = 0;
	public int num2 = 0;
	private int time_value = 0;
	// Use this for initialization
	void Start () {
	}
	
	
	// Update is called once per frame
	void Update () {
		print (time_obj.GetComponent<CountDown01> ().timer);
		time_value = (int)time_obj.GetComponent<CountDown01>().timer;
		
		num1 = time_value % 10;
		num2 = time_value / 10;
		One_obj.texture = number_texture [num1];
		Ten_obj.texture = number_texture [num2];
	}
}
