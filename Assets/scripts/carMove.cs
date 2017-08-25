using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMove : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Translate(Vector3.up * Time.deltaTime*speed);
	}
}
