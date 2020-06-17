using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEditor;
using System.IO;
using SKLibrary;
using TMPro;
public class VideoTest : MonoBehaviour 
{
	public VideoPlayer m_videoPlayer;
	public List<Texture2D> textures;
	public RenderTexture rt;
	public Camera camera;

	public int h = 36;
	public int t = 64;
	public TextMeshProUGUI text;
	public AudioSource audioSource;
	public AudioClip clip;

	public Material material;

	bool stopFlag = false;
	float time;
	void Start ()
	{
		material.color = Color.white;
		StartCoroutine(VideoScan());
	}
	
	void Update()
	{

		if (Input.GetKeyDown(KeyCode.A))
		{
			StartCoroutine(StartVideo());
			stopFlag = true;
			material.color = Color.black;
			audioSource.clip = clip;
			audioSource.Play();
		}
	}

	/// <summary>
	/// Videoを再生して読み取り
	/// </summary>
	/// <returns></returns>
	IEnumerator VideoScan()
	{
		while (true)
		{

			textures.Add(rt.CreateTexture2D(camera));
			yield return new WaitForSeconds(0.033f);
			//yield return null;
			if (stopFlag)
			{
				yield break;
			}
		}
	}
	

	IEnumerator StartVideo()
	{
		time = 0;


		text.gameObject.transform.parent.gameObject.SetActive(true);
		m_videoPlayer.enabled=false;
		foreach (Texture2D tex in textures)
		{
			text.SetText("");
			for (int i = h; i > 0; i--)
			{
				for (int j = 0; j < t; j++)
				{
					Color texPixel=tex.GetPixel(j, i);
					if ((texPixel.r+ texPixel.g + texPixel.b)/3 >= 0.5f)
					{
						text.text += "1";
					}
					else
					{
						text.text += "0";
					}
				}
				text.text += "\n";
			}
			yield return new WaitForSeconds(0.033f);
		}
	}
}
