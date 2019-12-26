using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDirector : MonoBehaviour {
	GameObject CumScore;
	GameObject TmpScore;
	int CumScoreVar = 0;
	string TmpScoreVar = "";

	// Use this for initialization
	void Start () {
		this.CumScore = GameObject.Find("CumScore");
		this.TmpScore = GameObject.Find("TmpScore");
	}
	
	// Update is called once per frame
	void Update () {
		this.CumScore.GetComponent<Text>().text = CumScoreVar.ToString("F0");
		this.TmpScore.GetComponent<Text>().text = TmpScoreVar;
	}

	public void IncreaseScore(){
		CumScoreVar += 115;
	}

	public void TmpScoreHit(){
		TmpScoreVar = "+115";
	}

	public void TmpScoreMiss(){
		TmpScoreVar = "MISS";
	}
}
