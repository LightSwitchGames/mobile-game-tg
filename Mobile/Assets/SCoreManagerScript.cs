using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SCoreManagerScript : MonoBehaviour
{
    [SerializeField]private Text scoreText;

    public float scoreValue = 0;
    

    void Update()
    {
        scoreValue+=1;
        scoreText.text = Convert.ToString(scoreValue);
    }
}
