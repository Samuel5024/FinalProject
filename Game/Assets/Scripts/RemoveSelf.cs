using UnityEngine;

public class RemoveSelf : MonoBehaviour
{
    public bool checkTimeout = true;
    public float timeOut = 5f;
    private float timer;

    private void OnEnable()
    {
        if(checkTimeout)
        {
            timer = Time.time + timeOut;
        }
    }

    public void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
        }
    }

    private void Remove()
    {
        gameObject.SetActive(false);
    }        
    
    private void Update()
    {
        if(checkTimeout && Time.time > timer)
        {
            if(CompareTag("Platform"))
            {
                gameObject.SetActive(false);
            }
        }
    }
}
