﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiedEffect : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, 1.2f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
