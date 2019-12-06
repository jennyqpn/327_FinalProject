using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HealthUpdateBullet : MonoBehaviour
{
    private int health;
    public Text healthText;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        //enemy
        if (other.gameObject.CompareTag("bullet"))
        {
            string[] healthValue = healthText.text.Split(' ');
            health = int.Parse(healthValue[1]);
            health += 20;
            healthText.text = "Health: " + health.ToString();
        }
    }
}
