﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testingtesting : MonoBehaviour {

    public GameObject plane;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
        {
            plane.SetActive(false);
        }
	}
}
