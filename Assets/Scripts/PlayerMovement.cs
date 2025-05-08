using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10;
    Rigidbody2D rb;
    Vector2 direction;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    // Update objects
    public void FixedUpdate()
    {
        rb.MovePosition(rb.position + (direction * speed * Time.deltaTime));
    }

    // Reading the player's inputs
    public void Update()
    {                               //GetAxisRaw is either go or stop, getAxis would smooth the movement
        direction = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
    }

    
}