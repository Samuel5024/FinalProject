using UnityEngine;

public class LevelMovement : MonoBehaviour
{
    // Reference to the floor's Rigidbody Component
    public Rigidbody rb;
    public float movementSpeed = -5f;


    void FixedUpdate()
    {
        Vector3 tempVect =  new Vector3(0, 0, 1);
        tempVect = tempVect.normalized * movementSpeed * Time.deltaTime;
        rb.MovePosition(transform.position + tempVect);        
    }
}