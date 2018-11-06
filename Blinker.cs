using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Blinker : MonoBehaviour {

	private GameObject CPUbutton;
	private float _Step = 0.05f;

	// Use this for initialization
	void Start () {
		CPUbutton = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		BlinkCPU();
	}

	private void BlinkCPU(){
		float CPUcolor = CPUbutton.GetComponent<Image>().color.a;
		if(CPUcolor < 0 || CPUcolor > 1){
			_Step = _Step * -1;
		}
		CPUbutton.GetComponent<Image>().color = new Color(255,255,255,CPUcolor + _Step);
	}



}