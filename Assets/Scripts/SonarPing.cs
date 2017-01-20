﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonarPing : MonoBehaviour {

	public GameObject sonarPointPrefab;

	public int pointCount;

	void sonar(){
		var me = Camera.main.transform;
		for (var x = 0; x < Camera.main.pixelWidth; x += 20) {
			for (var y = 0; y < Camera.main.pixelHeight; y += 20) {
				var ray = Camera.main.ScreenPointToRay (new Vector3 (x, y, 0f));
				Sonar.ShootRay (ray, sonarPointPrefab);

			}
		}

		Debug.Log (Sonar.pointCount);
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0)) {
			sonar ();
		}
	}
}