using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed;
    private Transform player;
    public Rigidbody2D rb;
    public Collider2D other;
    private Vector2 movement;
    private bool isPlayernear = false;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isPlayernear)
        {
            Vector2 direction = (player.position - transform.position).normalized;
            movement = direction; 
        }
        else
        {
            movement = Vector2.zero; 
        }
    }

    void FixedUpdate()
    {
        if (isPlayernear)
        {
            rb.linearVelocity = movement * moveSpeed; 
        }
        else
        {
            rb.linearVelocity = Vector2.zero; 
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("✅ Player entered detection range!");
            isPlayernear = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("❌ Player exited detection range!");
            isPlayernear = false;
        }
    }
}
