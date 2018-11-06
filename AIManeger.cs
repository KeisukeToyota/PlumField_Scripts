using UnityEngine;
using System;
using System.IO;
using System.Collections;

public class AIManeger : MonoBehaviour {
	//public NeuralNetwork[] nn;

	//private int[] hid = new int[2]{2,3};
	private string[] datacheck;
	private string[] split = {" "};
	private  string str;
	public Observer ob;



	// Use this for initialization
	void Start () {

	}
	// Update is called once per frame
	void Update () {

	}

	public double[] ActionDesitioin(){
		double[] data = new double[ob.output_data.Length];
		int i, j;
		for (i = 0; i < ob.output_data.Length; i++) {
			datacheck = ob.output_data.Split (split, StringSplitOptions.RemoveEmptyEntries);
			for (j = 0; j < datacheck.Length; j++) {
				data[j] = double.Parse(datacheck[j]);
				//print ("Data[" + j + "] : " + data[j]);
				//print ("data : " + data[j]);
			}
		}

		return data;
	}


}
