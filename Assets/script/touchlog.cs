﻿using UnityEngine;
using System.Collections;

public class touchlog : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            Debug.Log(Input.mousePosition);
        }
	}
}
