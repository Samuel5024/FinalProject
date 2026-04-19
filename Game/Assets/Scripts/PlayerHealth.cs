using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public PlayerRespawn playerRespawn;
    public HealthBar healthBar;
    public GameManager gameManager;
    public int health;
    public int maxHealth = 10;

    void Start()
    {
        health = maxHealth;
        healthBar.UpdateHealthBar(maxHealth, health);
    }

    public void TakeDamage(int amount) 
    {
        health -= amount;
        if(health <= 0)
        {
            healthBar.UpdateHealthBar(maxHealth, health);
            gameManager.EndGame();

        }
        else
        {
            healthBar.UpdateHealthBar(maxHealth, health);
        }
    }
}
