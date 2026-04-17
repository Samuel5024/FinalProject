using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int damage = 2;
   public void OnTriggerEnter(Collider other) 
    {
        Debug.Log("Obstacle entered");
        if(other.CompareTag("Obstacle")){
            playerHealth.TakeDamage(damage);
        }
    }
}
