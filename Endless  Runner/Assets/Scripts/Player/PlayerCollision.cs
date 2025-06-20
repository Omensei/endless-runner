using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private bool hasCrashed = false;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (hasCrashed) { return; }
        if (collision.CompareTag("Obstacle"))
        {
            hasCrashed = true;
            Debug.Log("Player has hit an obstacle");
            GameManager.Instance.TriggerGameOver();

        }
    }

}
