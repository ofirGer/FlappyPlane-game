using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacles : MonoBehaviour
{
    Transform player;

    float offset = 50f;

    private void Start()
    {
        player = FindObjectOfType<PlayerControllerX>().GetComponent<Transform>();
    }
    private void Update()
    {
        SetPosition();
    }

    void SetPosition()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, player.position.z - offset);
    }
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }
}
