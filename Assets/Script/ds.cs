using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ds : MonoBehaviour {

	public Texture2D test;
	public GameObject r;
	public GameObject b;
	public Text text;
	string ggggg;


	// Use this for initialization
	void Start ()
	{

		for (int i = 62; i > 0; i--)
		{
			for (int j = 0; j < 128; j++)
			{
				if (test.GetPixel(j,i).r >= 0.5f)
				{
					ggggg += "0";
				}
				else
				{
					ggggg += "1";
				}
			}
			ggggg += "\n";
		}
		
		text.text = ggggg;
	}
	
	// Update is called once per frame
	void Update () {

	}
}
