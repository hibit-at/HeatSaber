using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSaberController : MonoBehaviour {

	public GameObject ParticlePrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.D) && transform.rotation.z >= -.7){
			transform.Rotate(0,0,-15);
		}
		if(Input.GetKey(KeyCode.A) && transform.rotation.z <= .7){
			transform.Rotate(0,0,15);
		}
	}
}
