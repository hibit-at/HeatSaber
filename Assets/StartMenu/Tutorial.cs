using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Tutorial : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClick()
    { 
        string url = "https://www.youtube.com/watch?v=YVuArP40D2E";

        //Twitter投稿画面の起動
        Application.OpenURL(url);
    }
}
