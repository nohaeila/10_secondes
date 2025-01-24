using UnityEngine;


public class Player : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    public Rigidbody2D rig;
    public CoinManager cm;

    float direction;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //se precionar direita retorna 1. se precionar esquerda retorna -1. se n�o precionar nada retorna 0
        direction = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rig.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }


    }

    // � chamado pela fiica
    void FixedUpdate()
    {
        rig.linearVelocity = new Vector2(direction * speed, rig.linearVelocity.y);
    }

   /*private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("coin"))
        {
            Destroy(other.gameObject);
            cm.coinCount++;
        }
    }
   */


}
