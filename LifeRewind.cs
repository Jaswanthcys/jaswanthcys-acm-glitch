using UnityEngine;

public class LifeRewind : MonoBehaviour
{
    public Vector3 lastSafePosition;   //done
    public BirdScript bird;   // your existing BirdScript

    bool lifeUsed = false;

    void Start()
    {
        lastSafePosition = transform.position;
        lifeUsed = false;
    }

    void Update()
    {
        // Save safe position while bird is alive
        if (bird.birdIsAlive)
        {
            lastSafePosition = transform.position;
        }

        // Press R to get another life
        if (!bird.birdIsAlive && Input.GetKeyDown(KeyCode.R) && !lifeUsed)
        {
            RewindLife();
        }
    }

    void RewindLife()
    {
        transform.position = lastSafePosition;
        bird.birdIsAlive = true;
        lifeUsed = true;
    }
}