using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public PlayerRespawn playerRespawn;
    public int health;
    public int maxHealth = 10;

    void Start()
    {
        health = maxHealth;
        Debug.Log("You're Health is: " + health);
    }

    public void TakeDamage(int amount) 
    {
        health -= amount;
        if(health <= 0)
        {
            Debug.Log("You are out of health!!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
