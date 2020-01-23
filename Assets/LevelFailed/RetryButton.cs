using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour {

    public void Start()
    {

    }

    public void OnClick()
    {
        Debug.Log("clicked!");
        SceneManager.LoadScene("GameScene");
    }
}
