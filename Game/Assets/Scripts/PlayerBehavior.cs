using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public Rigidbody rb;
    public float movementSpeed = 100f;


    void Update()
    {
        rb.AddForce(0, 0, movementSpeed * Time.deltaTime);        
    }
}
