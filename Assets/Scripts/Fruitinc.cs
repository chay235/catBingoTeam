using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using TMPro;
using UnityEngine.EventSystems;

public class Fruitinc : MonoBehaviour
{
	//public RawImage RawImage;
	// Use this for initialization
	/*void Start()
	{
		sprite = Resources.Load<Sprite>("apple");

		GameObject image = GameObject.Find("Image");
		image.GetComponent<Image>().sprite = sprite;
	}
	//Texture2D myTexture;
	
	// Use this for initialization*/
	public TMP_Text applecount;
	public TMP_Text meloncount;
	public TMP_Text orangecount;
	public TMP_Text guavacount;
	public int fruit_counter = 0;
	void Start()
	{
		//Texture2D myTexture;
		//RawImage.enabled = false;

		if (clickControll.over == true)
		{
			// load texture from resource folder			
			//myTexture = Resources.Load("apple-removebg-preview") as Texture2D;
			//GameObject apple = GameObject.Find("apple");
			//apple.GetComponent<apple>().texture = myTexture;
			applecount.text = clickControll.applebingoinc.ToString();
			meloncount.text = clickControll.melonbingoinc.ToString();
			orangecount.text = clickControll.orangebingoinc.ToString();
			guavacount.text = clickControll.guavabingoinc.ToString();
		}
  //      else
  //      {
		//	applecount.text = fruit_counter.ToString();
		//	meloncount.text = clickControll.melonbingoinc.ToString();
		//	orangecount.text = clickControll.orangebingoinc.ToString();
		//	guavacount.text = clickControll.guavabingoinc.ToString();
		//}
	}
	//RawImage.enabled = true;
	//rawImage.gameObject.SetActive(true);\
	/*Texture2D myTexture1;
	if (clickControll.over == true)
	{
		myTexture1 = Resources.Load("guava") as Texture2D;
		GameObject rawImage1 = GameObject.Find("RawImage1");
		rawImage1.GetComponent<RawImage1>().texture = myTexture1;
	}*/
	
}
