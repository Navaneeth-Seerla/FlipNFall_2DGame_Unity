using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float time = 0;
    public float hightOffset = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(time < spawnRate)
        {
            time += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            time = 0;
        }

    }
    void SpawnPipe()
    {
        float lowestpoint = transform.position.y - hightOffset;
        float highestpoint = transform.position.y + hightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestpoint, highestpoint), 0), transform.rotation);
    }
}
