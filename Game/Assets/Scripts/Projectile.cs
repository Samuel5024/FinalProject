using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 1000f;
    private Rigidbody rb;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(rb != null)
        {
            rb.linearVelocity = transform.forward * speed * Time.deltaTime;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
