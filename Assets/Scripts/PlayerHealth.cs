using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 3;

    public TextMeshProUGUI gameoverText;
    public GameManager gameManager;

    void Start()
    {
       health = maxHealth; 
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if(health <= 0)
        {
            gameManager.EndGame();
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
