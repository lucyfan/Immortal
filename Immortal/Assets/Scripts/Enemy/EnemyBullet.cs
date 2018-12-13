﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {
    private float timer = 0f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Enemy")
            Destroy(this.gameObject);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer > 4) Destroy(this.gameObject);
    }
}
