﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComeIn : MonoBehaviour {

    // Use this for initialization

    private void OnTriggerEnter(Collider other)
    {
		SceneManager.LoadScene (2);
     // SceneManager.LoadScene(3);
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
