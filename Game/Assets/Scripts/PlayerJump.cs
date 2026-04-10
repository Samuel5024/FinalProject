using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerJump : MonoBehaviour
{
    private InputActionReference jumpButton;
    private float jumpHeight = 2.0f;
    private float gravityValue = -9.81f;
    private CharacterController characterController;
    private Vector3 playerVelocity;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void OnEnable()
    {
        jumpButton.action.performed += Jumping;
    }


    private void OnDisable()
    {
        jumpButton.action.performed -= Jumping;
    }

    private void Jumping(InputAction.CallbackContext obj)
    {
        if(!characterController.isGrounded)
        {
            return;
        }

        playerVelocity.y += Mathf.Sqrt(f:jumpHeight * -3.0f * gravityValue);
    }

    private void Update()
    {
        if(characterController.isGrounded && playerVelocity.y < 0) 
        {
            playerVelocity.y = 0f;
        }
        playerVelocity.y += gravityValue * Time.deltaTime;
        characterController.Move(playerVelocity * Time.deltaTime);
    }
}
