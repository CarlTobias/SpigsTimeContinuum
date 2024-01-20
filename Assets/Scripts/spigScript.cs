using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spigScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float upStrength, downStrength; // this public float alllows me to change the strength of the up and down movement in unity for convenience
    public GameObject spig;
    public gameLogic logic;
    public bool spigLife = true;
    private bool audioPlayed = false;

    public gameAudio audioVar;
    private void Awake()
    {
        audioVar = GameObject.FindGameObjectWithTag("Audio").GetComponent<gameAudio>();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<gameLogic>();
        spig = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) == true && spigLife == true)
        {
            myRigidbody.velocity = Vector2.up * upStrength; // Shoots the bird up high (Vector2.up is a preset for "(0, 1)" and * upStrength gives it more power)
            spig.transform.Rotate(new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.x + 20));
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow) == true && spigLife == true)
        {
            myRigidbody.velocity = Vector2.down * downStrength; // Shoots the bird down low (Vector2.up is a preset for "(0, 1)" and * downStrength gives it more power)
            spig.transform.Rotate(new Vector3(transform.rotation.x, transform.rotation.y, -20));
        }
    }    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (audioPlayed == false)
        {
            audioVar.playSFX(audioVar.spigDeath);
            audioPlayed = true;
        }
        
        logic.gameOver();
        spigLife = false;
    }
}
