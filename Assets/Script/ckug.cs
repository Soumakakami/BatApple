using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

public class ckug : MonoBehaviour {

	public Texture2D a;
	// Use this for initialization
	void Start ()
	{
		Texture2D tex = a;
		byte[] pngData = tex.EncodeToPNG();   // pngのバイト情報を取得.

		// ファイルダイアログの表示.
		string filePath = EditorUtility.SaveFilePanel("Save Texture", "", tex.name + ".png", "png");

		File.WriteAllBytes(filePath, pngData);
	}
	
	// Update is called once per frame
	void Update ()
	{

	}
}
