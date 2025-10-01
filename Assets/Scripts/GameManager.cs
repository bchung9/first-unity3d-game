using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] 
    private TextMeshProUGUI gameOverText;
    private TextMeshProUGUI gameWinText;

    void Start()
    {
        if (gameOverText != null && gameWinText != null)
        {
            gameOverText.gameObject.SetActive(false);
            gameWinText.gameObject.SetActive(false);
        }
    }

    public void EndGame()
    {
        if (gameOverText != null)
        {
            gameOverText.gameObject.SetActive(true);
        }
    }

    public void WinGame()
    {
        if (gameWinText != null)
        {
            gameWinText.gameObject.SetActive(true);
        }
    }
}