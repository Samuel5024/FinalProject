using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            gameManager.MainMenu();
        }
    }
}
