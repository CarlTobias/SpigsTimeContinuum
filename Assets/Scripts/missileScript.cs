using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileScript : MonoBehaviour
{
    public float life = 3;
    public GameObject explosion;
    public GameObject explosion2;
    public gameAudio audioVar;

    void Awake()
    {
        Destroy(gameObject, life);
    }

    void Start()
    {
        audioVar = GameObject.FindGameObjectWithTag("Audio").GetComponent<gameAudio>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(collision.gameObject);
            audioVar.playSFX(audioVar.explode);
            Instantiate(explosion, transform.position, Quaternion.identity);
            Instantiate(explosion2, transform.position, Quaternion.identity);
        }

        Destroy(gameObject);
    }
}
