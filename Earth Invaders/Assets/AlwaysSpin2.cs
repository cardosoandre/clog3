﻿using UnityEngine;
using System.Collections;

public class AlwaysSpin2 : MonoBehaviour {
	
	public float speed = 50;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Rotate (Vector3.forward * speed * Time.deltaTime);
		
	}
}
