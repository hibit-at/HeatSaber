using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class social : MonoBehaviour {

    GameObject ClearIndicator;
    
	// Use this for initialization
	void Start () {
        this.ClearIndicator = GameObject.Find("ClearIndicator");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick()
    {
        //urlの作成
        string esctext = UnityWebRequest.EscapeURL("HeatSaberを精度" + ClearIndicator.GetComponent<ClearIndicator>().shareAcc.ToString("f1") + "%でクリアしました！");
        string esctag = UnityWebRequest.EscapeURL("HeatSaber");
        string url = "https://twitter.com/intent/tweet?text=" + esctext + "&hashtags=" + esctag;

        //Twitter投稿画面の起動
        Application.OpenURL(url);
    }
}
