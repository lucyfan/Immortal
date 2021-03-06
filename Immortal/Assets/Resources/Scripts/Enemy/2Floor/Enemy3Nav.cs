﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy3Nav : MonoBehaviour {

   // NavMeshAgent agent;
    Transform player;
    public float speed;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player").GetComponent<Transform>();
       // agent = this.GetComponent<NavMeshAgent>();
        CHangePosition();
    }

    // Update is called once per frame
    void Update () {
        // agent.SetDestination(player.position);
        Vector3 dire = (player.position- this.transform.position).normalized;
        this.transform.Translate(dire * speed*Time.deltaTime, Space.World);
    }

    public void CHangePosition()
    {
        float x = Random.Range(-50, 50) / 100.0f;
        float y = 0;
        float z = Random.Range(-50, 50) / 100.0f;
        this.transform.position = player.position + new Vector3(x, y, z);
    }

}
