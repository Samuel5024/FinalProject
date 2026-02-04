using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Controller : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletVelocity = 20f;
    private GameObject bullet;
    private Rigidbody rb;


    public void CreateBullet(GameObject parentHand)
    {
        bullet = Instantiate(bulletPrefab, parentHand.transform);
        rb = bullet.GetComponent<Rigidbody>();
        rb.isKinematic = false;
        rb.linearVelocity = transform.forward * bulletVelocity;
    }

}
