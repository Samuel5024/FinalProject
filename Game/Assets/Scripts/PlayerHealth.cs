using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public PlayerRespawn playerRespawn;
    public HealthBar healthBar;
    public int health;
    public int maxHealth = 10;

    void Start()
    {
        health = maxHealth;
        healthBar.UpdateHealthBar(maxHealth, health);
        Debug.Log("You're Health is: " + health);
    }

    public void TakeDamage(int amount) 
    {
        health -= amount;
        if(health <= 0)
        {
            healthBar.UpdateHealthBar(maxHealth, health);
        }

        else
        {
            healthBar.UpdateHealthBar(maxHealth, health);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
