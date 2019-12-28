using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton_C : MonoBehaviour {

    public GameObject obj;
    GameObject thisScene;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick()
    {
        Debug.Log("clicked");
        obj.SetActive(true);
        thisScene = GameObject.Find("LevelCleared");
        thisScene.SetActive(false);
    }
}
