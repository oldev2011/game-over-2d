using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManeger : MonoBehaviour
{
    [HideInInspector] public static GameManeger Instance;
    [HideInInspector] public int Points = 0;

    public TMP_Text ScoreText;
    
    public Slider Slider;
    public int LivesSlider = 3;

    private void Awake()
    {
        Instance = this;
        ScoreText.text = "Score: " + Points.ToString();
    }

    private void Update()
    {
        Slider.value = LivesSlider;
        ScoreText.text = "Score: " + Points.ToString();
        if(LivesSlider == 0)
        {
                   
            
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        
    }
}
