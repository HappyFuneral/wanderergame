using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 1f; // A játékos mozgásának sebessége

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
       
    }

    Vector2 movement;


    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");

        movement.y = Input.GetAxisRaw("Vertical");

    }

    void FixedUpdate()
    {
        // Movement

        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}

/*
 using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float moveSpeed = 3f;
    Rigidbody2D rb;
    float movementTimer;
    Vector2 moveDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ChangeMovementDirection();
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
        rb.velocity = moveDirection * moveSpeed;
    }

    void ChangeMovementDirection()
    {
        float horizontal = Random.Range(-1f, 1f);
        float vertical = Random.Range(-1f, 1f);
        moveDirection = new Vector2(horizontal, vertical).normalized;
        movementTimer = Random.Range(1f, 3f);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            ChangeMovementDirection();
        }
    }
}
 */