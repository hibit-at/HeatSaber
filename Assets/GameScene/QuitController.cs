using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitController : MonoBehaviour {

    public GameObject obj;
    GameObject thisScene;

    // Update is called once per frame
    public void OnClick()
    {
        Debug.Log("clicked");
        obj.SetActive(true);
        thisScene = GameObject.Find("NormalPlay");
        thisScene.SetActive(false);
    }
}
