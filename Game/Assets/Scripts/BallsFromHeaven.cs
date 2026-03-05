using UnityEngine;

public class BallsFromHeaven : MonoBehaviour
{
    public GameObject cubePrefab;
    public float startHeight = 10f;
    public float interval = 8f;

    private float nextcubeTime = 0f;
    private ObjectPooler objectPooler;
    
    private void Start()
    {
        nextcubeTime = Time.time + interval;
        objectPooler = GetComponent<ObjectPooler>();
    }

    void Update()
    {
        if(Time.time > nextcubeTime)
        {
            Vector3 position = new Vector3(Random.Range(-4f, 4f), startHeight, Random.Range(-4f,4f));
            NewCube(position);
            nextcubeTime = Time.time + interval;
        }        
    }

    private void NewCube(Vector3 position)
    {
        //Instantiate(cubePrefab, position, Quaternion.identity);
        GameObject cube = objectPooler.GetPooledObject();
        if(cube != null)
        {
            cube.transform.position = position;
            cube.transform.rotation = Quaternion.identity;
            cube.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        }
    }
}
