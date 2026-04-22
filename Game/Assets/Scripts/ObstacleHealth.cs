using UnityEngine;

public class ObstacleHealth : MonoBehaviour
{
       public void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Bullet"))
        {
            gameObject.SetActive(false);
        }
    }
}
