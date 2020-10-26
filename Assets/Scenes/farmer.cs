using System;
using UnityEngine;

public class farmer : MonoBehaviour
{   //Variavéis
    public Animator      anime;
    public Rigidbody2D   playerRigidbody2D;
    public int           jumpForce;
    public int           speed;

    //Sons
    public AudioSource   runSound;
    public AudioSource   jumpSound;

    public bool          jump;
    public bool          running;
    public bool          idle;

    //Virar Sprites
    private bool         facingRight;

    //Verifica o chão
    public Transform     GroundCheck;
    private bool         grounded;
    public LayerMask     whatIsGround;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        Moviment();
        Jump();

        grounded = Physics2D.OverlapCircle(GroundCheck.position, 0.2f, whatIsGround);
        anime.SetBool("jump", !grounded);
        anime.SetBool("running", running);
        anime.SetBool("idle", idle);

        
    }

    void Moviment()
    {
        var moviment = Input.GetAxis("Horizontal");
        transform.position += new Vector3(moviment, 0, 0) * Time.deltaTime * speed;
        Flip(moviment);

        if (Convert.ToBoolean(moviment) && grounded)
        {
            running = true;
            
        }
        else
        {
            running = false;
            runSound.Play();

        }

        
    }


    void Jump()
    {
        if (Input.GetButtonDown("Jump") && grounded)
        {
            playerRigidbody2D.AddForce(new Vector2(0, jumpForce));
            jump = true;
            running = false;
            jumpSound.Play();
        }
    }
    
    void Flip(float moviment)
    {
        if(moviment > 0 && facingRight || moviment < 0 && !facingRight)
        {
            facingRight = !facingRight;

            Vector3 theScale = transform.localScale;

            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }
}
