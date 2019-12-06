using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HealthUpdate : MonoBehaviour
{
    private int health = 100;
    public Text healthText;

    // Use this for initialization
    void Start()
    {
        healthText.text = "Health: " + health.ToString();
        //health = int.Parse(healthText.text);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        string[] healthValue = healthText.text.Split(' ');
        health = int.Parse(healthValue[1]);

        //enemy
        if (other.gameObject.CompareTag("enemy"))
        {
            health -= 20;
            healthText.text = "Health: " + health.ToString();
        }

        //good food
        if (other.gameObject.CompareTag("pear"))
        {
            health += 10;
            healthText.text = "Health: " + health.ToString();
        }

        if (other.gameObject.CompareTag("apple"))
        {
            health += 25;
            healthText.text = "Health: " + health.ToString();
        }

        if (other.gameObject.CompareTag("kiwi"))
        {
            health += 15;
            healthText.text = "Health: " + health.ToString();
        }

        if (other.gameObject.CompareTag("strawberry"))
        {
            health += 20;
            healthText.text = "Health: " + health.ToString();
        }

        if (other.gameObject.CompareTag("banana"))
        {
            health += 55;
            healthText.text = "Health: " + health.ToString();
        }


        //
        if (other.gameObject.CompareTag("pizza"))
        {
            health -= 50;
            healthText.text = "Health: " + health.ToString();
        }

        if (other.gameObject.CompareTag("muffin"))
        {
            health -= 15;
            healthText.text = "Health: " + health.ToString();
        }

        if (other.gameObject.CompareTag("hotdog"))
        {
            health -= 25;
            healthText.text = "Health: " + health.ToString();
        }

        if (other.gameObject.CompareTag("burger"))
        {
            health -= 30;
            healthText.text = "Health: " + health.ToString();
        }

        if(health <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        SceneManager.LoadScene("GameEndScene");
    }
}