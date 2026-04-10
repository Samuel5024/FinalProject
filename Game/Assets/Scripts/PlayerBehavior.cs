using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public CharacterController characterController;
    public float movementSpeed = 3.0f;
    // public float downwardForce = -5.0f;
    

    void Update()
    {
        Vector3 Move = new Vector3(0, 0, movementSpeed * Time.deltaTime);
        characterController.Move(Move);        
    }
}
