using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;
    private float inputX;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        inputX = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {

        rb.velocity = new Vector2(inputX * moveSpeed, rb.velocity.y);
    }




}
    
