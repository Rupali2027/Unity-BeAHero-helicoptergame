using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEditor;
public class events : MonoBehaviour
{
	public ScoreManager theScoreManager;
    public void ReplayGame()
    {
    	
      
    	SceneManager.LoadScene("Game");
	theScoreManager.scoreCount = 0;
    	 theScoreManager.scoreIncreasing = true;
    	 
    	
    	}
    	
    public void QuitGame()
    {
	 //UnityEditor.EditorApplication.isPlaying = false;
        //Debug.Log("QUIT!");
    	Application.Quit();
    	}

}
