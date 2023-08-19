using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverScreen;
    [SerializeField] Text scoreText;
    public GameObject scoreUI;
    public bool reloadingScene = false;
    
   
    // Start is called before the first frame update
  

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        scoreUI.SetActive(false); 
    }
    // Update is called once per frame
    public void Restart()
    {
        reloadingScene = true;
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
