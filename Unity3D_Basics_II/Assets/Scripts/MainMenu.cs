﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void QuitGameButton()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else            
        Application.Quit();
#endif
    }

    public void StartFirstButton()
    {
        SceneManager.LoadScene("FoodCollector First");
    }

    public void StartThirdButton()
    {
        SceneManager.LoadScene("FoodCollector Third");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("StartScene");
    }
}
