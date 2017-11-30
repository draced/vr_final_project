using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class Basket : MonoBehaviour
{
    public AudioSource basket; //reference to the basket sound
    public Text scoreText; //score text 
    private int score = 0; //used to incremement our score 

    void OnTriggerEnter(Collider col) //if the ball hits the collider inside the net
    {
        if (col.gameObject.tag == "Basket")
        {
            ScoreUpdate(); //update the score 
        }
        basket = GetComponent<AudioSource>();

    }

    private void ScoreUpdate() //update the score 
    {
        score++;
        scoreText.text = score.ToString();
        if (!basket.isPlaying) 
        {
            basket.Play();
        }
        else {
            //not in the basket 
            basket.Stop();
        }
    }
}
