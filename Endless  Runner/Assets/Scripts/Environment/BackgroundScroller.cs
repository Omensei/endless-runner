using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{

    [SerializeField] private float scrollSpeed = 2f;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        float newX = Mathf.Repeat(Time.time * scrollSpeed,20f);
        transform.position = startPosition + Vector3.left * newX;
    }
}
