using UnityEngine;
using System.Collections;

public class TimeCount : MonoBehaviour {
	public float startTime = 91.0f; //seconds
	public float timer;
	public Texture[] number;
	GUITexture one;
	GUITexture ten;
	int time;
	int one_time;
	int ten_time;
	
	// Use this for initialization
	void Start () {

		timer = startTime;

		one = transform.Find ("1").GetComponent<GUITexture> ();
		ten = transform.Find ("10").GetComponent<GUITexture> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		Settime ();
		reset ();
	}

	private void reset(){
		startTime -= Time.deltaTime;
		timer = startTime;
	}
	
	private void Settime(){
		one_time = (int)timer % 10 ;
		timer -= one_time ;
		timer /= 10 ;
		ten_time = (int)timer % 10 ;
		
		one.texture = Decidetime (one_time);
		ten.texture = Decidetime (ten_time);
	}

	private Texture Decidetime(int numbers){
		switch(numbers){
		case 0:{
			return number[0];
		}
		case 1: {
			return number[1];
		}
		case 2: {
			return number[2];
		}
		case 3: {
			return number[3];
		}
		case 4: {
			return number[4];
		}
		case 5: {
			return number[5];
		}
		case 6: {
			return number[6];
		}
		case 7: {
			return number[7];
		}
		case 8: {
			return number[8];
		}case 9: {
			return number[9];
		}
		default:
			return number[0];
			break;
		}
	}
}
