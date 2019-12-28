using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearIndicator : MonoBehaviour {

	public GameObject director;
	GameObject indicator;

	// Use this for initialization
	void Start () {
		this.indicator = GameObject.Find("AccValue");
		indicator.GetComponent<Text>().text = director.GetComponent<ScoreDirector>().GetAcc();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
