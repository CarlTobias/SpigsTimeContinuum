using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pointTrigger : MonoBehaviour
{
    public gameLogic logic;
    public spigScript life; // Find a way to make it so that when the player dies, no more points
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<gameLogic>(); // Finds a game object with a tag "Point Logic" and gets the script "pointLogic" by looking through its components
        life = GameObject.FindGameObjectWithTag("Player").GetComponent<spigScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3 && life.spigLife == true)
        {
            logic.addScore(1);
        }
        

    }
}
