using UnityEngine;

public class TakingDamage : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int damage = 1;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("3D Collision detected with: " + collision.gameObject.name);

        if(collision.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(damage);
        }
    }
}
