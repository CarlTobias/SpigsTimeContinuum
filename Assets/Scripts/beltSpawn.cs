using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beltSpawn : MonoBehaviour
{
    public GameObject prefab;
    public GameObject prefab2;
    public float spawnRate1 = 2; // How many seconds in between spawns for the first prefab
    public float spawnRate2 = 5; // How many seconds in between spawns for the second prefab
    private float timer1 = 0; // Number that counts up
    private float timer2 = 0; // Number that counts up
    private float offset = 1.5f; // Value to offset the asteroid belt and wall

    // Start is called before the first frame update
    void Start()
    {
        spawnBelt();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer1 < spawnRate1)
        {
            timer1 += Time.deltaTime;
        }

        else
        {
            spawnBelt();
            timer1 = 0;
        }

        if (timer2 < spawnRate2)
        {
            timer2 += Random.Range(0, 6) * Time.deltaTime;
        }

        else
        {
            spawnWall();
            timer2 = 0;
        }

    }

    void spawnBelt()
    {
        float lowPoint = transform.position.y - offset; // Lowest point that the belt will spawn
        float highPoint = transform.position.y + offset * 2.5f; // Highest point

        Instantiate(prefab, new Vector3(transform.position.x, Random.Range(lowPoint, highPoint), 0), transform.rotation);
    }

    void spawnWall()
    {
        float closePoint = transform.position.x - offset * 5f; // Closest point where the wall will spawn respective to the Spawn Area
        float farPoint = transform.position.x + offset * 5f; // Farthest point where the wall will spawn respective to the Spawn Area

        Instantiate(prefab2, new Vector3(Random.Range(closePoint, farPoint), transform.position.y, 0), transform.rotation);
    }
}