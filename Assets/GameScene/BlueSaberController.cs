using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSaberController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.RightArrow) && transform.rotation.z >= -.7){
			transform.Rotate(0,0,-10);
		}
		if(Input.GetKey(KeyCode.LeftArrow) && transform.rotation.z <= .7){
			transform.Rotate(0,0,10);
		}
	}
}
