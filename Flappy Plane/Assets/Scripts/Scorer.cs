using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Scorer : MonoBehaviour
{
    public int score;
    [SerializeField] Text scoreText;
    [SerializeField] Text scoreText2;

    float addSpeed = 1;

    [SerializeField] Text highscoreGameObject;
    [SerializeField] Text gameOverHigescore;
    Higescore higescore;
    PlayerControllerX playerController;
    GameManager gameManager;
    bool isDead;
    [SerializeField] int addingSpeedFrequency = 5;

    void Start()
    {
        playerController = FindObjectOfType<PlayerControllerX>().GetComponent<PlayerControllerX>();
        higescore = FindObjectOfType<Higescore>().GetComponent<Higescore>();       
        gameManager = FindObjectOfType<GameManager>().GetComponent<GameManager>();
        isDead = gameManager.isDead;
    }

    void Update()
    {
        scoreText.text = score.ToString();
        scoreText2.text = score.ToString();
        highscoreGameObject.text = "HIGESCORE: " + higescore.GetHigescore().ToString();     
            ShowGameOverHigescore();              
    }
    public void ShowGameOverHigescore()
    {
        if (score > higescore.GetHigescore())
        {
            gameOverHigescore.text = " NEW HIGESCORE! ";
            higescore.TrySetNewHigescore(score);
        }
        else
        {
            gameOverHigescore.text = "HIGESCORE: " + higescore.GetHigescore().ToString();
        }
    }
    private void OnTriggerEnter(Collider scorer)
    {
        AddScore(1);
        ProccesseAddSpeed();
    }
    private void ProccesseAddSpeed()
    {
        if (score % addingSpeedFrequency == 0 && score >= addingSpeedFrequency)
        {
            playerController.playerSpeed += addSpeed;
        }
    }
    private void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
    }
}
