using UnityEngine;
using System;
using System.Collections;

public class DefenceNN : MonoBehaviour{
	
	public const double Rlow = -0.30;
	public const double Rhigh = 0.30;
	
	private double[][] output_value;
	public double[][][] weight_forward;
	public double[][] bias_forward;
	private double[][][] weight_back;
	private double[][] bias_back;
	private double[][] relative_error;
	private double eqsiron;
	private double eta;
	private double alpha;
	private int N;
	private int number_learn;
	private int num_input;
	private int num_hidden;
	private int num_out;
	private double gain;
	private int[] number_hidden_layer;
	private int layer_size;
	
	public LoadInputData ld;
	public NeuralNetworkAI nnai;
	
	public string a;
	public string b;
	
	
	
	void Start () {
		
	}
	
	
	public DefenceNN(int n_in, int n_hid, int n_out, int[] hid_l, double ga, double et, double al, int n_c, int l_n)
	{
		gain = ga;
		eta = et;
		alpha = al;
		//Test ();
		num_out = n_out;
		num_hidden = n_hid;
		num_input = n_in;
		N = n_c;
		number_learn = l_n;
		number_hidden_layer = hid_l;
		//print (hid_l[0]);
		layer_size = n_hid;
		//出力層の分プラス１している
		layer_size += 1;
		
		output_value = new double[layer_size][];
		weight_forward = new double[layer_size][][];
		weight_back = new double[layer_size][][];
		bias_forward = new double[layer_size][];
		bias_back = new double[layer_size][];
		relative_error = new double[layer_size][];
		
		nnai = new NeuralNetworkAI ();
		for (int x = 0; x < layer_size; x++)
		{
			if (x == layer_size - 1)
			{
				output_value[x] = new double[n_out];
				relative_error[x] = new double[n_out];
				bias_forward[x] = new double[number_hidden_layer[layer_size - 2]];
				bias_back[x] = new double[number_hidden_layer[layer_size - 2]];
				for(int y = 0;y < number_hidden_layer[layer_size - 2];y++){
					bias_forward[x][y] = 0;
				}
				
			}
			else
			{
				output_value[x] = new double[number_hidden_layer[x]];
				relative_error[x] = new double[number_hidden_layer[x]];
				bias_forward[x] = new double[number_hidden_layer[x]];
				bias_back[x] = new double[number_hidden_layer[x]];
				for(int y = 0;y < number_hidden_layer[x];y++){
					bias_forward[x][y] = 0;
				}
			}
			
		}
		
		
		//誤差伝搬の計算ではbackは逆から計算しなければならない
		for (int x = 0; x < layer_size; x++){
			if (x == 0)
			{
				weight_forward[x] = new double[num_input][];
				weight_back[x] = new double[num_input][];
				for (int y = 0; y < num_input; y++)
				{
					weight_forward[x][y] = new double[number_hidden_layer[0]];
					weight_back[x][y] = new double[number_hidden_layer[0]];
					for (int z = 0; z < number_hidden_layer [0]; z++) {
						weight_forward[x][y][z] = 0;
					}
				}
			}
			else
			{
				weight_forward[x] = new double[number_hidden_layer[x - 1]][];
				weight_back[x] = new double[number_hidden_layer[x - 1]][];
				
				if (x != layer_size - 1)
				{
					for (int y = 0; y < number_hidden_layer[x - 1]; y++)
					{
						weight_forward[x][y] = new double[number_hidden_layer[x]];
						weight_back[x][y] = new double[number_hidden_layer[x]];
						for (int z = 0; z < number_hidden_layer [x]; z++) {
							weight_forward [x][y][z] = 0; 
						}
					}
				}
				else
				{
					for (int y = 0; y < number_hidden_layer[x - 1]; y++)
					{
						weight_forward[x][y] = new double[num_out];
						weight_back[x][y] = new double[num_out];
						for (int z = 0; z < num_out; z++) {
							weight_forward [x][y][z] = 0;
						}
					}
				}
			}
		}
		//initialize();
		//print ("bias : " + bias_forward[1][1]);
		//print ("weight : " + weight_forward[1][1][1]);
	}
	
	
	//~NeuralNwtwork()
	
	
	public void initialize()
	{
		//System.Random rand =new System.Random();
		//double urand = ((double)rand.Next() / 0x7fff * (Rhigh - Rlow) + Rlow);
		for (int x = 0; x < layer_size; x++){
			if (x == 0){
				for (int y = 0; y < num_input; y++){
					for (int z = 0; z < number_hidden_layer[0]; z++){
						weight_forward[x][y][z] = urand();
						weight_back[x][y][z] = 0;
						//bias_forward[x][y] = urand();
						//bias_back[x][y] = 0;
					}
				}
			}
			else{
				if (x != layer_size - 1 && x != 0){
					for (int y = 0; y < number_hidden_layer[x - 1]; y++){
						for (int z = 0; z < number_hidden_layer[x]; z++){
							weight_forward[x][y][z] = urand();
							weight_back[x][y][z] = 0;
							//print("x , y" + y + " " +z);
							//print("x , y"+ y + " ----" + z + bias_forward[x][y]);
							//bias_forward[x][y] = urand();
							//bias_back[x][y] = 0;
						}
					}
				}
				else{
					for (int y = 0; y < number_hidden_layer[x - 1]; y++){
						for (int z = 0; z < num_out; z++){
							weight_forward[x][y][z] = urand();
							weight_back[x][y][z] = 0;
							//bias_forward[x][y] = urand();
							//bias_back[x][y] = 0;
						}
					}
				}
			}
			
		}
	}
	
	
	public void forwardPropagation(double[] x)
	{
		a = "";
		double sum;
		//print("NN weight " + x[6]);
		for (int layer = 0; layer < layer_size; layer++)
		{
			if (layer == 0)
			{
				for (int nel = 0; nel < number_hidden_layer[layer]; nel++)
				{
					sum = 0;
					for (int el = 0; el < num_input; el++)
					{
						//print("weight_forward : " + weight_forward[layer][el][nel]);
						//print("weight_forward 1 : " + weight_forward[1][1][1]);
						//print("weight_forward 2 : " + weight_forward[2][2][2]);
						sum += weight_forward[layer][el][nel] * x[el];
						
					}
					//print ("bias_forward : " + bias_forward[layer][nel]);
					sum += bias_forward[layer][nel];
					output_value[layer][nel] = sigmoid(sum);
					//print("output : " + output_value[layer][nel]);
					//print("sum : " + sum);
				}
			}
			else if (layer < layer_size - 1)
			{
				for (int nel = 0; nel < number_hidden_layer[layer]; nel++)
				{
					sum = 0;
					for (int el = 0; el < number_hidden_layer[layer - 1]; el++)
					{
						sum += weight_forward[layer][el][nel] * output_value[layer - 1][el];
						
					}
					sum += bias_forward[layer][nel];
					output_value[layer][nel] = sigmoid(sum);
					//print("output : " + output_value[layer][nel]);
					//print("sum : " + sum);
				}
			}
			else
			{
				for (int nel = 0; nel < num_out; nel++)
				{
					sum = 0;
					for (int el = 0; el < number_hidden_layer[layer - 1]; el++)
					{
						sum += weight_forward[layer][el][nel] * output_value[layer - 1][el];
					}
					sum += bias_forward[layer][nel];
					output_value[layer][nel] = sigmoid(sum);
					//print("output : " + output_value[layer][nel]);
					a += Convert.ToString(RoundingOutput(output_value[layer_size - 1][nel]));
					
					
					//print ("hogehogehogehogehogehogehogehogehogehogehogehogehogehoge");
					//print("sum : " + sum);
				}
				//nnai.setInput(a);
				//nnai.inputresult = a;
				nnai.ActionDecision(a,b);
				//print ("nnnnnnnnnnnnnnnnn  " + nnai.inputresult);
				//print ("result : " + a);
				
			}
			
		}
		
	}
	
	public int RoundingOutput(double output){
		int result;
		if (output >= 0.3) {
			result = 1;
		} else {
			result = 0;
		}
		return result;
	}
	
	public double OutputMoveValue(){
		return 0;
		
	}
	
	
	
	public void input_weight(int x,int y,int z, double v){
		weight_forward [x] [y] [z] = v;
	}
	
	public void input_bias(int x,int y, double v){
		bias_forward[x] [y] = v;
	}
	
	public void Test(string dat){
		print (dat);
	}
	
	
	
	public double sigmoid(double x)
	{
		return 1 / (1 + Math.Exp(-gain * x));
	}
	
	private double getRandom(){
		System.Random r = new System.Random(Environment.TickCount);
		return r.NextDouble () - 0.5f;
	}
	
	private double urand(){
		System.Random rand =new System.Random();
		return ((double)rand.Next() / 0x7fff * (Rhigh - Rlow) + Rlow);
	}
}
