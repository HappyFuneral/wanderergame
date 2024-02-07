
using UnityEngine;


public class enemy : MonoBehaviour
{
    public float moveSpeed = 3f;
    Rigidbody2D rb;
    float movementTimer;
    Vector2 moveDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ChangeMovementDirection();
        rb.freezeRotation = true;
    }

    void Update()
    {
        movementTimer -= Time.deltaTime;
        if (movementTimer <= 0f)
        {
            ChangeMovementDirection();
        }
    }

    void FixedUpdate()
    {
        rb.velocity = moveDirection * moveSpeed * Time.fixedDeltaTime;
    }

    void ChangeMovementDirection()
    {
        float horizontal = Random.Range(-1f, 1f);
        float vertical = Random.Range(-1f, 1f);
        moveDirection = new Vector2(horizontal, vertical).normalized;
        movementTimer = Random.Range(1f, 3f);
        rb.rotation = 0;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            ChangeMovementDirection();
            rb.rotation = 0;
        }
    }
}

