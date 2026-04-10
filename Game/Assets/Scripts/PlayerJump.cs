using UnityEngine;
using UnityEngine.InputSystems;

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
}
