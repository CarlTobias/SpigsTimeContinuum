using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spigShoot : MonoBehaviour
{
    public Transform missileSpawn;
    public GameObject missile;
    public float missileSpeed = 10;
    private spigScript life;

    // Start is called before the first frame update
    void Start()
    {
        life = GameObject.FindGameObjectWithTag("Player").GetComponent<spigScript>();
    }
    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && life.spigLife == true)
        {
            var shootMissile = Instantiate(missile, missileSpawn.position, missileSpawn.rotation);
            shootMissile.GetComponent<Rigidbody2D>().velocity = (missileSpawn.right * missileSpeed);
        }
    }
}
