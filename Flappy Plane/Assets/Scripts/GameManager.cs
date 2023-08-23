using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverScreen;
    [SerializeField] Text scoreText;
    [SerializeField] GameObject scoreUI;


    public bool isDead;

    private void Start()
    {
        isDead = false;
    }
    public void GameOver()
    {
            
        gameOverScreen.SetActive(true);
        scoreUI.SetActive(false); 
    }  
    public void Restart()
    {
        
        SceneManager.LoadScene(0);
    }
     public void LoadMenu()
    {
        SceneManager.LoadScene(1);
    }
     public void Quit()
    {
        Application.Quit();
    }
}
