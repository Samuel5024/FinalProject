using UnityEngine;

public class LevelMovement : MonoBehaviour
{
    // Reference to the floor's Rigidbody Component
    public Rigidbody rb;
    public float movementSpeed = -100f;


    void Update()
    {
        rb.AddForce(0, 0, movementSpeed * Time.deltaTime);        
    }
}
