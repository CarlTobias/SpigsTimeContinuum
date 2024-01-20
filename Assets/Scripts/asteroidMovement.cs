using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidMovement : MonoBehaviour
{
    public float moveSpeed = 5;
    public float beltDeath = -15; // X-value of the place I want the belt to get deleted
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Moves the position of the asteroid belt to the left
        // (multiplying it with Time.deltaTime allows it so that multiplying Vector3.Left and moveSpeed to be unaffected no matterr the frame rate)
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < beltDeath)
        {
            Debug.Log("Blasting Asteroids");
            Destroy(gameObject); // Deletes the game object once it passes the desired position
        }
    }
}
