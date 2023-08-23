using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEditor.UI;
public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject explosion;
    [SerializeField] GameObject mainCamera;
    [SerializeField] GameObject hoodCamera;

    [SerializeField] GameObject SfxPlayer;
    [SerializeField] AudioClip explosionClip;
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
        PlayExplosionFx();
        gameObject.SetActive(false);
        PlayExplosionSound();
        gameManager.isDead = true;
        Invoke(nameof(ShowEndScreen), 1f);

    }
    private void PlayExplosionSound()
    {
        audioSource.clip = explosionClip;
        audioSource.Play();
    }

    private void PlayExplosionFx()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
    }

    private void Update()
    {
        if (transform.position.y > 20 || transform.position.y < -20)
        {
            hoodCamera.transform.parent = null;
            mainCamera.SetActive(true);
            gameObject.SetActive(false);
            gameManager.isDead = true;
            Invoke(nameof(ShowEndScreen), 1f);
        }
    }
    void ShowEndScreen()
    {
        gameManager.GameOver();
    }


}
