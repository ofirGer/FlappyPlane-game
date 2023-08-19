using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject plane;
    public GameObject pipes;
    public float maxHeight = 21f;
    float minHeight = 0f;
    float spawnRate = 3f;
    float offset = 60f;
    private void Start()
    {
        InvokeRepeating(nameof(Spawn), 0, spawnRate);
    }

    void Update()
    {
        transform.position = Vector3.forward * (plane.transform.position.z + offset);

    }

    void Spawn()
    {
        float randomHeight = Random.Range(minHeight, maxHeight); 
        // Spawn the pipes at random he
        Instantiate(pipes, new Vector3(transform.position.x, randomHeight, transform.position.z), Quaternion.identity);
        
        if (!plane.activeSelf)
        {
            CancelInvoke(nameof(Spawn));
        }
        
    }
}
