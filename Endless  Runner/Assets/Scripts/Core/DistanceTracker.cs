using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTracker : MonoBehaviour
{
    public Transform player;

    public float DistanceTraveled { get; private set; }

    private float startX;

    private void Start()
    {
        if (player == null)
        {
            Debug.LogError("DistanceTracker No Player assigned");
            enabled = false;
            return;

        }

        startX = player.position.x;
    }

    private void Update()
    {
        DistanceTraveled = Mathf.Max(0f, player.position.x - startX);
    }
}
