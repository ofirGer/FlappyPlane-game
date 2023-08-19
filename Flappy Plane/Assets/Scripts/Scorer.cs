using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Scorer : MonoBehaviour
{
    public int score;
    public GameObject pipes;
    public Text scoreText;
    public Text scoreText2;

    public GameObject SfxPlayer;
    public AudioClip pointClip;
    AudioSource audioSource;
    float addSpeed = 1;

    public Text highscoreGameObject;
    public Text gameOverHigescore;
    Higescore higescore;
    PlayerControllerX playerController;
    void Start()
    {
        audioSource = SfxPlayer.GetComponent<AudioSource>();
        playerController = GetComponent<PlayerControllerX>();
        higescore = FindObjectOfType<Higescore>().GetComponent<Higescore>();
      
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        scoreText2.text = score.ToString();
        highscoreGameObject.text = "HIGESCORE: " + higescore.GetHigescore().ToString();

        if (score > higescore.GetHigescore())
        {
            gameOverHigescore.text = " NEW HIGESCORE! " ;
        }
        else
        {
            gameOverHigescore.text = "HIGESCORE: " + higescore.GetHigescore().ToString();
        }
        

    }
    private void OnTriggerEnter(Collider scorer)
    {
        audioSource.clip = pointClip;
        score += 1;
        //audioSource.Play();

        if (score % 5 == 0 && score >= 5)
        {       
            playerController.playerSpeed += addSpeed;
        }
       

       

    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }

}
