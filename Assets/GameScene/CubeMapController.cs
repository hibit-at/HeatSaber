using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMapController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	

	// Update is called once per frame
	void Update () {
		transform.Translate(0, -Time.deltaTime ,0);
	}
}
