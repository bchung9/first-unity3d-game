using UnityEngine;
using TMPro;

public class CoinCollect : MonoBehaviour
{
    private int Coin = 0;

    public TextMeshProUGUI coinText;

    public TextMeshProUGUI gamewinText;
    public GameManager gameManager;

    // public AudioClip coinClip;
    // AudioSource collectAudio;

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Coin")
        {
            Coin++;
            // collectAudio = GetComponent<AudioSource>();
            // collectAudio.clip = coinClip;
            // collectAudio.Play();
            coinText.text = "Coin(s): " + Coin.ToString();
            Debug.Log("Coin(s) Collected: " + Coin);
            Destroy(other.gameObject);
            if(Coin == 8)
            {
                gameManager.WinGame();
                Debug.Log("You Win!");
            }
        }
    }
}
