using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDirector : MonoBehaviour {
    public GameObject failed;
	GameObject CumScore;
	GameObject TmpScore;
    GameObject CurTime;
    GameObject Gauge;
	int CumScoreVar = 0;
	string TmpScoreVar = "";
    float CurTimeVar = 0;
    float HP = 3;

    // Use this for initialization
    void Start () {
		this.CumScore = GameObject.Find("CumScore");
		this.TmpScore = GameObject.Find("TmpScore");
        this.CurTime = GameObject.Find("CurTime");
        this.Gauge = GameObject.Find("Gauge");
	}
	
	// Update is called once per frame
	void Update () {
        this.CurTimeVar += Time.deltaTime;
		this.CumScore.GetComponent<Text>().text = CumScoreVar.ToString("f0");
		this.TmpScore.GetComponent<Text>().text = TmpScoreVar;
        this.CurTime.GetComponent<Text>().text = CurTimeVar.ToString("f1") + "s";
        if (HP < 0)
        {
            failed.SetActive(true);
            GameObject thisScene = GameObject.Find("NormalPlay");
            thisScene.SetActive(false);
        }
        if (HP > 5) HP = 5;
        this.Gauge.GetComponent<RectTransform>().sizeDelta = new Vector2(HP * 100, 50f);
    }

	public void IncreaseScore(){
        HP += 1;
		CumScoreVar += 115;
	}

	public void TmpScoreHit(){
		TmpScoreVar = "+115";
	}

	public void TmpScoreMiss(){
        HP -= 1;
        TmpScoreVar = "MISS";
	}
}
