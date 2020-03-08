using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreDirector : MonoBehaviour {
    public GameObject MissPrefab;
    GameObject TotalScore;
    GameObject Indicator;
    GameObject TmpScore;
    GameObject CurTime;
    GameObject Gauge;
	GameObject AccValue;
    GameObject TimeGauge;
    GameObject CubeMap;
    int TotalScoreVar = 0;
    string IndicatorText = "";
    Color32 IndicatorColor = Color.white;
    Color32 TmpScoreColor = Color.white;
    string TmpScoreVar = "";
    float CurTimeVar = 0;
	public static float AccValueVar;
    float HP = 3;
	int count;
	int score = 0;

    // Use this for initialization
    void Start() {
        this.TotalScore = GameObject.Find("TotalScore");
        this.Indicator = GameObject.Find("Indicator");
        this.TmpScore = GameObject.Find("TmpScore");
        this.CurTime = GameObject.Find("CurTime");
        this.Gauge = GameObject.Find("Gauge");
		this.AccValue = GameObject.Find("AccValue");
        this.TimeGauge = GameObject.Find("TimeGauge");
		AccValueVar = 100f;
        this.TimeGauge.GetComponent<Image>().fillAmount = 0.0f;
        Invoke("Action",0.1f);
    }

    void Action()
    {
        GetComponent<AudioSource>().Play();
        this.CubeMap = GameObject.Find("CubeMap");
        CubeMap.transform.position = new Vector3(0, 3.6f, 0);
        CubeMap.GetComponent<CubeMapController>().speed = 1.0f;
    }

    // Update is called once per frame
    void Update() {
        this.CurTimeVar += Time.deltaTime;
        this.TotalScore.GetComponent<Text>().text = TotalScoreVar.ToString("n0");
        this.Indicator.GetComponent<Text>().text = IndicatorText;
        this.Indicator.GetComponent<Text>().color = IndicatorColor;
        this.TmpScore.GetComponent<Text>().text = TmpScoreVar;
        this.TmpScore.GetComponent<Text>().color = TmpScoreColor;
        this.CurTime.GetComponent<Text>().text = CurTimeVar.ToString("f0") + "s";
        this.TimeGauge.GetComponent<Image>().fillAmount = CurTimeVar/90;
        if (HP < 0)
        {
            SceneManager.LoadScene("LevelFailed");
        }
        if (HP > 5) HP = 5;
        this.Gauge.GetComponent<RectTransform>().sizeDelta = new Vector2(HP * 50, 25f);
		if (CurTimeVar > 90){
            SceneManager.LoadScene("LevelCleared");
		}
		this.AccValue.GetComponent<Text>().text = AccCalc();
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("GameScene");
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
    }

	string AccCalc(){
		if (count > 0){
			AccValueVar = (float)TotalScoreVar / count / 1.15f;
			return AccValueVar.ToString("f1") + "%";
		}
		return "100.0%";
	}

    public void TmpScoreHit(float rot) {
        double tmp = Mathf.Abs(rot);
        tmp = 115 - tmp * 100;
        score = (int)tmp + 6;
        if (score > 115) score = 115;
        TmpScoreVar = "+" + score.ToString("f0");
        HP += 1;
        TotalScoreVar += score;
        if (score < 100)
        {
            IndicatorText = "poor";
            IndicatorColor = Color.red;
            TmpScoreColor = Color.red;
        }
        else if (score < 110)
        {
            IndicatorText = "good";
            IndicatorColor = Color.yellow;
            TmpScoreColor = Color.yellow;
        }
        else if (score < 115)
        {
            IndicatorText = "Great!";
            IndicatorColor = Color.green;
            TmpScoreColor = Color.green;
        }
        else
        {
            IndicatorText = "PERFECT!!";
            IndicatorColor = Color.white;
            TmpScoreColor = Color.white;
        }
		count += 1;
    }

    public void IndicatorHit() {
    }

    public void TmpScoreMiss() {
        GameObject go = Instantiate(MissPrefab) as GameObject;
        HP -= 1;
        TmpScoreVar = "";
        IndicatorText = "MISS";
        IndicatorColor = Color.black;
        count += 1;
    }

	public static float GetAccScenes () {
        return AccValueVar;
    }

}
