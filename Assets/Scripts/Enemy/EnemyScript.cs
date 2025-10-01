using UnityEngine;
using UnityEngine.EventSystems;
using static UnityEngine.GraphicsBuffer;

public class EnemyScript : MonoBehaviour
{
    public float moveSpeed = 3f;
    Rigidbody2D rb;
    Transform target;
    Vector2 moveDirection;

    public float health, maxHealth = 3f;
    
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
    }

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        health = maxHealth;
    }

    void Update()
    {
        if (target)
        {
            Vector2 direction = (target.position - transform.position).normalized;
            moveDirection = direction;
        }
    }

    private void FixedUpdate()
    {
        if (target)
        {
            rb.linearVelocity = new Vector2(moveDirection.x, moveDirection.y) * moveSpeed;
        }
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        Debug.Log("Took Damage. Remaning Health: " + health);
    }
}
