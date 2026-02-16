using UnityEngine;

public class OneExtraLife : MonoBehaviour //done
{
    public BirdScript bird;
    public LogicScript logic;

    Vector3 lastSafePosition;
    bool extraLifeUsed = false;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        lastSafePosition = transform.position;
    }

    void Update()
    {
        // Save position only when bird is alive
        if (bird.birdIsAlive)
        {
            lastSafePosition = transform.position;
        }

        // FIRST DEATH → PRESS R → REWIND
        if (!bird.birdIsAlive && !extraLifeUsed && Input.GetKeyDown(KeyCode.R))
        {
            UseExtraLife();
        }

        // SECOND DEATH → GAME OVER
        if (!bird.birdIsAlive && extraLifeUsed)
        {
            logic.gameOver();
        }
    }

    void UseExtraLife()
    {
        rb.linearVelocity = Vector2.zero;          // STOP movement
        rb.angularVelocity = 0f;
        transform.position = lastSafePosition;

        bird.birdIsAlive = true;
        extraLifeUsed = true;
    }
}