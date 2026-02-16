using UnityEngine;
using System.Collections.Generic;

public class TimeRewind : MonoBehaviour  //done
{
    List<Vector3> positions = new List<Vector3>();
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.R))
        {
            if (positions.Count > 0)
            {
                rb.simulated = false;
                transform.position = positions[0];
                positions.RemoveAt(0);
            }
        }
        else
        {
            rb.simulated = true;
            positions.Insert(0, transform.position);

            if (positions.Count > 200)
                positions.RemoveAt(positions.Count - 1);
        }
    }

    // ✅ ADD THIS PART AT THE END
    public void ResetRewind()
    {
        positions.Clear();
        rb.simulated = true;
    }
}