using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformmecolor : MonoBehaviour {

	public float colourChangeDelay = 0.5f;
	float currentDelay = 0f;
	bool colourChangeCollision = false;

	void OnTriggerEnter(Collider collider) {
		Debug.Log("Contact was made!");
		colourChangeCollision = true;
		currentDelay = Time.time + colourChangeDelay;
	}
	void checkColourChange()
	{        
		if(colourChangeCollision)
		{
			transform.GetComponent<Renderer>().material.color = Color.yellow;
			if(Time.time > currentDelay)
			{
				transform.GetComponent<Renderer>().material.color = Color.white;
				colourChangeCollision = false;
			}
		}
	}

	void Update()
	{
		checkColourChange();
	}
}
