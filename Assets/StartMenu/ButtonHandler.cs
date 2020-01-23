using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    public void Start()
    {

    }


    public void OnClick()
    {
        SceneManager.LoadScene("GameScene");
    }
}