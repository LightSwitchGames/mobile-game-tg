using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public bool isPaused = false;
    public float scoreValue = 0;
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private Sprite muteOriginal;
    [SerializeField] private Sprite muteAlt;
    [SerializeField] private Sprite vibOriginal;
    [SerializeField] private Sprite vibAlt;
    [SerializeField] private Sprite musicOriginal;
    [SerializeField] private Sprite musicAlt;
    [SerializeField]private Text scoreText;
    
    public void PauseButton()
    {
        if (isPaused == false)
        {
            StartCoroutine(Pause());
        }
        
        if (isPaused == true)
        {
            StartCoroutine(Unpause());
        }
    }

    IEnumerator Pause()
    {
        pausePanel.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        isPaused = true;
        Time.timeScale = 0;
    }
    IEnumerator Unpause()
    {
        Time.timeScale = 1.0f;
        pausePanel.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        isPaused = false;
    }

    private void Update()
    {
        if (isPaused == false)
        {
            scoreValue+=1;
        }
        
        scoreText.text = Convert.ToString(scoreValue);
    }
}
