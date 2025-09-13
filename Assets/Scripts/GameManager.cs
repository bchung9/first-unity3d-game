using UnityEngine;
using TMPro; // Required for TextMeshPro

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI gameOverText; // Reference to your Game Over Text

    void Start()
    {
        // Ensure the Game Over text is hidden at the start
        if (gameOverText != null)
        {
            gameOverText.gameObject.SetActive(false);
        }
    }

    public void EndGame()
    {
        // Display the Game Over text
        if (gameOverText != null)
        {
            gameOverText.gameObject.SetActive(true);
        }
        // Optionally, add other game over logic here (e.g., stop player movement, show restart button)
    }
}