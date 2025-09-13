using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 3;

    public TextMeshProUGUI gameoverText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       health = maxHealth; 
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if(health <= 0)
        {
            gameoverText.text = "Game Over!";
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }

    }
}
