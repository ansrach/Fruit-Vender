using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShootOBJ : MonoBehaviour
{
    public GameObject arCamera;   
    public Text scoreText;

    public AudioClip fruitSquash;
    public AudioClip explosionSound;
    
    public ParticleSystem blueParticle;  
    public ParticleSystem greenParticle;
    public ParticleSystem yellowParticle;
    public ParticleSystem blackParticle;    
    
    int pointValue;
    private Timer timer;

    void Start()
    {
        timer = GameObject.Find("Canvas").GetComponent<Timer>();
    }
    public void Shoot()
    {
        RaycastHit hit;
        if(timer.gameStarted == true)
        {
            if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
            {
                if (hit.transform.tag == "blue")
                {
                    print(pointValue);
                    AddCoin(5);
                    AudioSource.PlayClipAtPoint(fruitSquash, hit.transform.position);
                    Instantiate(blueParticle, hit.transform.position, blueParticle.transform.rotation);
                    Destroy(hit.transform.gameObject);
                }
                if (hit.transform.tag == "green")
                {
                    print(pointValue);
                    AddCoin(10);
                    AudioSource.PlayClipAtPoint(fruitSquash, hit.transform.position);
                    Instantiate(greenParticle, hit.transform.position, greenParticle.transform.rotation);
                    Destroy(hit.transform.gameObject);
                }
                if (hit.transform.tag == "yellow")
                {
                    print(pointValue);
                    AddCoin(20);
                    AudioSource.PlayClipAtPoint(fruitSquash, hit.transform.position);
                    Instantiate(yellowParticle, hit.transform.position, yellowParticle.transform.rotation);
                    Destroy(hit.transform.gameObject);
                }
                if (hit.transform.tag == "bomb")
                {
                    print("แตกพ่าย");
                    AddCoin(-20);
                    AudioSource.PlayClipAtPoint(explosionSound, hit.transform.position);
                    Instantiate(blackParticle, hit.transform.position, blackParticle.transform.rotation);
                    Destroy(hit.transform.gameObject);
                }
            }
        }
        
    }
    public void AddCoin(int score)
    {
        pointValue = pointValue + score;
        scoreText.text = "SCORE: " + pointValue.ToString();
    }
    public void Restart()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
