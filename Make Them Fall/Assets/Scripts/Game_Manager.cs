using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Game_Manager : MonoBehaviour
{

    public int score = 0;
    [SerializeField] private TMP_Text scoreText;
    void Start()
    {
        
    }

    
    void Update()
    {
        scoreText.text = score.ToString();
    }

    public void GameOver()
    {
        SceneManager.LoadScene(0);
    }
}
