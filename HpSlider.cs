using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HpSlider : MonoBehaviour {

	Slider _slider01;
	Slider _slider02;
	// Use this for initialization
	void Start () {
		_slider01 = GameObject.Find ("Slider01").GetComponent<Slider> ();
		_slider02 = GameObject.Find ("Slider02").GetComponent<Slider> ();
	}
	float _hp=1;
	// Update is called once per frame
	void Update () {
		_hp -= 0.01f;
		if (_hp < 0) {
			_hp = 1;
		}
		_slider01.value = _hp;
		_slider02.value = _hp;
	}
}
