using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public float threshold; //Y-value of Transform
    public void FixedUpdate()
    {
        if(transform.position.y < threshold)
            RespawnPlayer();
    }

    public void RespawnPlayer()
    {
        transform.position = new Vector3(0f, 5f, 0f);
    }
}
