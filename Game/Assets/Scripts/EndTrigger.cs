using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter() 
    {
        Debug.Log("We have entered");
        gameManager.CompleteLevel();
    }
}
