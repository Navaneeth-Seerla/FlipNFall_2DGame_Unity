using UnityEngine;

public class PipemoveScript : MonoBehaviour
{

    public float movespeed = 20;
    public float deadZone = -60;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movespeed) * Time.deltaTime;

        if(transform.position.x < deadZone)
        {
            Debug.Log("Pipe Destroyed");
            Destroy(gameObject);
        }
    }
}
