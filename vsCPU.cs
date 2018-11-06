using UnityEngine;
using System.Collections;

public class vsCPU : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Escape)){
			print ("********************************        **************************" );
			Application.Quit();
		}
	
	}

	public void pushButton(){
		Debug.Log("push Button!!");
		Application.LoadLevel("vsCPU");
	}
}
