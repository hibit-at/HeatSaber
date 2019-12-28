using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDirector : MonoBehaviour {
    public GameObject failed;
    GameObject CumScore;
    GameObject Indicator;
    GameObject TmpScore;
    GameObject CurTime;
    GameObject Gauge;
    int CumScoreVar = 0;
    string IndicatorText = "";
    string TmpScoreVar = "";
    float CurTimeVar = 0;
    float HP = 3;

    // Use this for initialization
    void Start() {
        this.CumScore = GameObject.Find("CumScore");
        this.Indicator = GameObject.Find("Indicator");
        this.TmpScore = GameObject.Find("TmpScore");
        this.CurTime = GameObject.Find("CurTime");
        this.Gauge = GameObject.Find("Gauge");
    }

    // Update is called once per frame
    void Update() {
        this.CurTimeVar += Time.deltaTime;
        this.CumScore.GetComponent<Text>().text = CumScoreVar.ToString("f0");
        this.Indicator.GetComponent<Text>().text = IndicatorText;
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

    public void TmpScoreHit(float rot) {
        double tmp = Mathf.Abs(rot);
        tmp = 115 - tmp * 100;
        int score = (int)tmp + 6;
        if (score > 115) score = 115;
        TmpScoreVar = "+" + score.ToString("f0");
        HP += 1;
        CumScoreVar += score;
        if (score < 100) IndicatorText = "poor";
        else if (score < 110) IndicatorText = "good";
        else if (score < 115) IndicatorText = "Great!";
        else IndicatorText = "PERFECT!!";
    }

    public void IndicatorHit() {
    }

    public void TmpScoreMiss() {
        HP -= 1;
        TmpScoreVar = "";
        IndicatorText = "MISS";
    }
}
