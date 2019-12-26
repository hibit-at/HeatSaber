using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public GameObject obj;
    GameObject thisScene;

    public void OnClick()
    {
        Debug.Log("clicked");
        obj.SetActive(true);
        thisScene = GameObject.Find("StartMenu");
        thisScene.SetActive(false);
    }
}