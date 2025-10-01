using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody2D rb;
    private Vector2 input;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        input.Normalize();
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = input * speed;

    }
}
