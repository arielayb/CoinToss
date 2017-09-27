using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpin : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
	}

	void FixedUpdate()
	{
		//Transform transform;
		transform.Rotate(new Vector3(0.0f, 45f, 0.0f) * Time.deltaTime);
	}
}
