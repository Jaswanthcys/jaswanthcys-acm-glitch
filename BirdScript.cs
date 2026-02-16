using System.Collections;
using System.Collections.Generic;

using UnityEngine;
 
public class BirdScript : MonoBehaviour  //done
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
 
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
            SoundManager.instance.PlayFlap();
            Debug.Log("Flap sound called");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        {
            birdIsAlive = false;
        }
        SoundManager.instance.PlayHit();
        
    }
} 