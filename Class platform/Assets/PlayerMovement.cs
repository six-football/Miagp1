using UnityEngine;
using System.Collections;
 public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;
    public float jumpforce;
    public Transform ceillingCheck;
    public Transform groundCheck;
    public LayerMask groundObjects;

    private Rigidbody2D rb;
    private bool facingRight = true;
    private float moveDirection;
    private bool isJumping = false;



    // Awake is called after all objects are initialized. Called in a radom order.
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();// Will look for a componet on this GameObject (what the script is attached to)of type Rigibody2D.
    }

    // Update is called once per frame
    void Update()
    {
        // Get Inputs
        moveDirection = Input.GetAxis("Horizontal");// Scale of -1->1.
        // Animate
        if (moveDirection > 0 && !facingRight)
        {
            FlipCharacter();
        }
        else if (moveDirection < 0 && facingRight)
        {
            FlipCharacter();
        }
        // Move
        rb.velocity = new Vector2(moveDirection * moveSpeed, rb.velocity.y);
    }


    private void FlipCharacter()
    {
        facingRight = !facingRight; // Inverse bool
        transform.Rotate(0f, 180f, 0f);


    }
    IEnumerator PowerUpSpeed()
    {
        moveSpeed = 9;
        yield return new WaitForSeconds(5);
        moveSpeed = 5;

    }
    public void SpeedPowerUp()
    {

        StartCoroutine(PowerUpSpeed());
    }
}

