﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadgame : MonoBehaviour {
	//	public Button button;
	// Use this for initialization
	void Start () {
	}

	void Awake(){
		Button button = gameObject.GetComponent<Button>() ;
		button.onClick.AddListener (btClick);
	}

	// Update is called once per frame
	void Update () {
	}

	void Destroy(){
		Destroy (this.gameObject);
		Invoke ("btClick", 5f);
	}

	void btClick(){
		print ("click");
		this.Destroy ();
//		SceneManager.LoadScene (1);
	}


	//	void TeenShow(){
	//		Canvas.DOFade (1, 2);
	//	}
}