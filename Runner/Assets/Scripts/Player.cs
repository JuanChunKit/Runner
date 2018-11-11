using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if(transform.position.y < -5.0f )
		{
			transform.position = new Vector3( 0.0f, 0.0f, 0.0f );
		}
	}
}
