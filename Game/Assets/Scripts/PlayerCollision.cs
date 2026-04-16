using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int damage = 2;
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Obstacle")
        {
            playerHealth.TakeDamage(damage);
            Debug.Log("You have taken damage");
        }
        else
        {
            Debug.Log("Something isn't working...");
        }
    }
}
