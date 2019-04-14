﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F3Creater : MonoBehaviour
{
    public static Vector3[] Location = { new Vector3(0, 0, 0), new Vector3(19, 0, 0), new Vector3(38,0,0), new Vector3(9, 0, -16.5f), new Vector3(28.5f,0,-16.5f), new Vector3(0, 0, -33.2f), new Vector3(19, 0, -33.2f), new Vector3(38,0,-33.2f) };
    Quaternion angle = Quaternion.Euler(0, 30, 0);
    int ord;
    string path;
    string name;
    GameObject room;
    Transform Door;
    GameObject f1;
    Transform f2;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 8; i++)
        {
            ord = Random.Range(0, 25);
            path = string.Format("Prefabs/Rooms/Room1 ({0})", ord);
            name = string.Format("Dooors ({0})", i);
            room = (GameObject)Resources.Load(path);
            Door = GameObject.Find(name).GetComponent<Transform>();
            f1 = Instantiate(room, Location[i], angle);
            Door.parent = f1.transform;
            f2 = f1.transform.GetChild(0);
            f2 = f2.transform.GetChild(3);
            Destroy(f2.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}