﻿using UnityEngine;
using System.Collections;

public class soleilkitomb : MonoBehaviour {
	public float speed = 0.1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (-Vector2.up * Time.deltaTime * speed);
	
	}
}
