using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehavior : MonoBehaviour
{
    public CharacterController characterController;
    public float movementSpeed = 3.0f;
    public float rotationSpeed = 90.0f;
    

    // void Update()
    // {
    //     characterController.AddForce(0, 0, movementSpeed * Time.deltaTime);        
    // }
}
