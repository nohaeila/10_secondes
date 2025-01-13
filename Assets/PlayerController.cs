using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variables pour le mouvement
    public float moveSpeed = 5f;
    public float jumpForce = 10f;

    // Gestion du saut
    private bool isGrounded;
    private bool canDoubleJump;

    // Références
    private Rigidbody2D rb;
    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;

    void Start()
    {
        // Récupérer le composant Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Déplacement horizontal
        float horizontalInput = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(horizontalInput * moveSpeed, rb.linearVelocity.y);

        // Gérer le saut
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }

        // Flip du personnage selon la direction
        if (horizontalInput > 0)
            transform.localScale = new Vector3(1, 1, 1);
        else if (horizontalInput < 0)
            transform.localScale = new Vector3(-1, 1, 1);
    }

    void Jump()
    {
        if (isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            canDoubleJump = true; // Autoriser le double saut
        }
        else if (canDoubleJump)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            canDoubleJump = false; // Désactiver le double saut
        }
    }

    void FixedUpdate()
    {
        // Vérifie si le joueur est au sol
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
    }

}


