using UnityEngine;

public class DealDamage : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int damage = 2;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("You have taken damage");
            playerHealth.TakeDamage(damage);
        }
    }
}
