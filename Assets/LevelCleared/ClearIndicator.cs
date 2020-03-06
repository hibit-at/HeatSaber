using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearIndicator : MonoBehaviour {

	public GameObject director;
	float thisSceneAcc;
	GameObject indicator;
    public float shareAcc = 0.0f;

	// Use this for initialization
	void Start () {
		this.indicator = GameObject.Find("AccValue");
		thisSceneAcc = ScoreDirector.GetAccScenes();
		Debug.Log(thisSceneAcc);
		indicator.GetComponent<Text>().text = thisSceneAcc.ToString("f1") + "%";
        shareAcc = thisSceneAcc;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
