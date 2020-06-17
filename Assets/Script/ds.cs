using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;


public class ds : MonoBehaviour {

	public Texture2D f;
	int a = 0;

	public int h=31;
	public int t = 64;
	public TextMeshProUGUI ttttt;
	Texture2D[] dsds=new Texture2D[7000];
	float timer;

	private void Start()
	{
		Application.targetFrameRate = 31;
		for (int i = 1; i <= 4653; i++)
		{

			dsds[i - 1] = (Texture2D)Resources.Load(i.ToString());
		}
	}

	private void Update()
	{
		timer += Time.deltaTime;
			ttttt.SetText("");
			f = dsds[a];
			for (int i = h; i > 0; i--)
			{
				for (int j = 0; j < t; j++)
				{
					if (dsds[a].GetPixel(j, i).r >= 0.5f)
					{
						ttttt.text += "1";
					}
					else
					{
						ttttt.text += "0";
					}
				}
				ttttt.text += "\n";
			}
			a++;
			if (a == 4653)
			{
				Debug.Log(timer);
			}
	}

}
