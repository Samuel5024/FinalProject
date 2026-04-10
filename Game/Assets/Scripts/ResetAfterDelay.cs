using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetAfterDelay : MonoBehaviour
{
    public float delaySeconds = 5f;
    private Vector3 spawnPoint;

    private void Start()
    {
        spawnPoint = transform.position;
    }

    public void Reset()
    {
        StartCoroutine(AfterDelay());
    }

    IEnumerator AfterDelay()
    {
        yield return new WaitForSeconds(delaySeconds);
        transform.position = spawnPoint;

        Rigidbody rb = GetComponent<Rigidbody>();
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}