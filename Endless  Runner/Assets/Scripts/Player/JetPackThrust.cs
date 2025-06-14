using UnityEngine;

public class JetPackThrust : MonoBehaviour
{
    [SerializeField] private float jetpackForce = 10f;
    [SerializeField] private KeyCode KeyCode = KeyCode.Space;


    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Space))
        {

            rb.AddForce(Vector2.up * jetpackForce);
        }
    }



}
    
