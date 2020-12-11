using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermanager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;


	private ScoreManager theScoreManager;
	
    void Start()
    {
        gameOver = false;
        Time.timeScale=1;
        
        theScoreManager = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver)
        {
        	Time.timeScale = 0;
        	theScoreManager.scoreIncreasing = false;
        	
        	gameOverPanel.SetActive(true);
        	
        	
        }
        
    }
}
