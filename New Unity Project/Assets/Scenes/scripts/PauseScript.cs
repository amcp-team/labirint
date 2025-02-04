﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseScript : MonoBehaviour
{

    public float timer;
    public float timing;
    public bool isPaused;
    public GameObject pauseMenu;
    
    void Start()
    {
        timer = 0f;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isPaused == false)
        {
            isPaused = true;
            
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isPaused == true)
        {
            isPaused = false;
        }

        if(isPaused == true)
        {
            timing = 0;
            pauseMenu.SetActive(true);
        }
        else if (isPaused == false)
        {
            timer += Time.deltaTime;
            timing = 1;
            pauseMenu.SetActive(false);
        }
    }

    public void resumeButton(bool state)
    {
        isPaused = state;
    }

    public void QuitButton()
    {
        
        SceneManager.LoadScene("Menu");
    }
}
