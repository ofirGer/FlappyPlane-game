using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject plane;
    [SerializeField] GameObject pipes;
    [SerializeField] float maxHeight = 21f;
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
        // Spawn the pipes at random heights
        Instantiate(pipes, new Vector3(transform.position.x, randomHeight, transform.position.z), Quaternion.identity);
        
        if (!plane.activeSelf)
        {
            CancelInvoke(nameof(Spawn));
        }
        
    }
}
