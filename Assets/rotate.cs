﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{

    public float rotateSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
	if (Input.GetButton("Fire1")){
     	this.transform.Rotate(0,rotateSpeed,0);
	}
    }
}
