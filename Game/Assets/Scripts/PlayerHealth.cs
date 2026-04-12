using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public PlayerRespawn playerRespawn;
    public int health;
    public int maxHealth = 10;

    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(int amount) 
    {
        health -= amount;
        if(health <= 0)
        {
            playerRespawn.RespawnPlayer();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
