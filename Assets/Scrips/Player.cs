using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float jump;
    private float move;

    private bool isOnFloor;
    private bool isMoving;

    public Rigidbody2D rb;
    public Animator anim;
    public SpriteRenderer sprite;

    private AudioSource jumpSound;
    private AudioSource starSound;

    void Start()
    {
        GameObject jumpSoundObj = GameObject.Find("JumpSound");
        if (jumpSoundObj != null)
            jumpSound = jumpSoundObj.GetComponent<AudioSource>();
        else
            Debug.LogWarning("JumpSound GameObject não encontrado!");

        GameObject starSoundObj = GameObject.Find("StarSound");
        if (starSoundObj != null)
            starSound = starSoundObj.GetComponent<AudioSource>();
        else
            Debug.LogWarning("StarSound GameObject não encontrado!");
    }

    void Update()
    {
        move = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(move * speed, rb.linearVelocity.y);

        if (Input.GetButtonDown("Jump") && isOnFloor)
        {
            rb.AddForce(new Vector2(0f, jump));
            isOnFloor = false;
        }

        if (move > 0)
        {
            isMoving = true;
            sprite.flipX = false;
        }
        else if (move < 0)
        {
            isMoving = true;
            sprite.flipX = true;
        }
        else
        {
            isMoving = false;
        }

        anim.SetBool("isMoving", isMoving);
        anim.SetBool("isOnFloor", isOnFloor);
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Ground"))
        {
            isOnFloor = true;

            if (jumpSound != null)
                jumpSound.Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Star"))
        {
            if (starSound != null)
                starSound.Play();
        }
    }
}
