﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Generator : MonoBehaviour 
{
	/// <summary>
	/// The maximum distance between the player and the
	/// sound generator for the player to be able to activate it.
	/// </summary>
	public float activateDistance = 3f;

	/// <summary>
	/// The time between each "pulse" of sound,
	/// if we are active only
	/// </summary>
	public float soundPulseInterval = 0.5f;

	public float rayInterval = 5;

	/// <summary>
	/// If the sound generator is emitting sound
	/// </summary>
	public bool isActive = false;



	/// <summary>
	/// What color we should be if we are unactive
	/// </summary>
	public Color unactiveColor = Color.red;

	/// <summary>
	/// What color we should be if we are active
	/// </summary>
	public Color activeColor = Color.green;



	/// <summary>
	/// The time until next pulse.
	/// </summary>
	private float timeUntilNextPulse = 0f;

	/// <summary>
	/// The material of the object
	/// </summary>
	private Material mat;

	// Use this for initialization
	void Start () {
		mat = GetComponent <Renderer> ().material;
		mat.color = (isActive) ? activeColor : unactiveColor;
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (isActive)
		{
			if (timeUntilNextPulse > 0)
			{
				timeUntilNextPulse--;
			} else
			{
				/* Send out a spherical sound */
				Sonar.
			}
		}
		/* Check if player has pressed space */
		if (Input.GetKeyDown (KeyCode.T))	
		{
			Transform player = GameObject.FindGameObjectWithTag ("Player").transform;
			if (Vector3.Distance (transform.position, player.position) <= activateDistance)
			{
				/* Invert the active state */
				isActive = !isActive;

				/* Update the color of the material according to the state of the sound generator */
				mat.color = (isActive) ? activeColor : unactiveColor;

			}
		}
	}

	void MakeSound()
	{
		int x, y;
		int length = 50;
		float angle = 0.0f;

		while (angle < 2 * Mathf.PI)
		{
			x = (int)(length * Mathf.Cos (angle));
			y = (int)(length * Mathf.Sin (angle));
			angle += rayInterval;

		}
	}
}
