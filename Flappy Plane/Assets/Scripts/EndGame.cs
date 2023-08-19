using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEditor.UI;
public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject explosion;
    public GameObject mainCamera;
    public GameObject hoodCamera;

    public GameObject SfxPlayer;
    public AudioClip explosionClip;
    AudioSource audioSource;

    GameManager gameManager;
    private void Start()
    {
        audioSource = SfxPlayer.GetComponent<AudioSource>();
        gameManager = FindObjectOfType<GameManager>();
    }
    public void OnCollisionEnter(Collision collision)
    {
        hoodCamera.transform.parent = null;
        mainCamera.SetActive(true);
        Instantiate(explosion, transform.position, Quaternion.identity);
        gameObject.SetActive(false);

        audioSource.clip = explosionClip;
        audioSource.Play();

        Invoke(nameof(ShowEndScreen), 1f);

    }
    private void Update()
    {
        if (transform.position.y > 20 || transform.position.y < -20)
        {
            hoodCamera.transform.parent = null;
            mainCamera.SetActive(true);
            gameObject.SetActive(false);
            Invoke(nameof(ShowEndScreen), 1f);
        }
    }
    void ShowEndScreen()
    {
        gameManager.GameOver();
    }


}
