using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{


    //private const float jump_amount = 7f;
    //private Rigidbody2D playertRigidbody2D;

    //private void Awake()
    //{
    //    playertRigidbody2D = GetComponent<Rigidbody2D>();
    //}

    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButton(0))
    //    {
    //        Jump();
    //    }
    //}

    //private void Jump()
    //{
    //    playertRigidbody2D.velocity = Vector2.up * jump_amount;
    //}

    [SerializeField] float jumpHeight = 10;
    //[SerializeField] float gravityScare = 5;
    //[SerializeField] float fallGravityScale = 15;

    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            rb.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
            //rb.gravityScale = gravityScare;
            //float jumpForce = Mathf.Sqrt(jumpHeight * (Physics2D.gravity.y * rb.gravityScale) * -2) * rb.mass;
            
        }
        //if (rb.velocity.y > 0)
        //{
        //    rb.gravityScale = gravityScare;
        //}
        //else
        //{
        //    rb.gravityScale = fallGravityScale;
        //}
    }


    //[RequireComponent(typeof(Rigidbody2D))]
    //public class PlayerController : MonoBehaviour
    //{
    //    public Vector3 jump;
    //    public float jumpForce = 2.0f;

    //    public bool isGrounded;
    //    Rigidbody2D rb;
    //    void Start()
    //    {
    //        rb = GetComponent<Rigidbody2D>();
    //        jump = new Vector3(0.0f, 2.0f, 0.0f);
    //    }

    //    void OnCollisionStay()
    //    {
    //        isGrounded = true;
    //    }

    //    void Update()
    //    {
    //        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
    //        {

    //            rb.AddForce(jump * jumpForce, ForceMode2D.Impulse);
    //            isGrounded = false;
    //        }
    //    }
    //}

    //[SerializeField] private float jumpHeight = 10f;
    //[SerializeField] private Transform groundChecker;
    //[SerializeField] private LayerMask groundLayer;
    //private Rigidbody2D rigidbody2d;

    //private void Start()
    //{
    //    rigidbody2d = GetComponent<Rigidbody2D>();
    //}
    //private void Update()
    //{
    //    if (Input.GetAxis("Jump") > 0)
    //    {
    //        rigidbody2d.AddForce(new(0, jumpHeight));
    //    }
    //}

    //public Vector2 speed = new Vector2(10, 10);

    //private Vector2 movement = new Vector2(1, 1);

    //// Use this for initialization
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    float inputX = Input.GetAxis("Horizontal");
    //    float inputY = Input.GetAxis("Vertical");

    //    movement = new Vector2(
    //        speed.x * inputX,
    //        speed.y * inputY);

    //    if (Input.GetKeyDown("space"))
    //    {
    //        transform.Translate(Vector3.up * 260 * Time.deltaTime, Space.World);
    //    }

    //}
    //void FixedUpdate()
    //{
    //    // 5 - Move the game object
    //    rigidbody2D.velocity = movement;
    //    //rigidbody2D.AddForce(movement);

    //}


    //private CharacterController character;
    //private Vector3 direction;

    //public float gravity = 9.81f * 2f;
    //public float jumpForce = 7f;

    //private void Awake()
    //{
    //    character = GetComponent<CharacterController>();
    //}

    //private void OnEnable()
    //{
    //    direction = Vector3.zero;
    //}

    //private void Update()
    //{
    //    direction += Vector3.down * gravity * Time.deltaTime;

    //    if (character.isGrounded)
    //    {
    //        direction = Vector3.down;

    //        if (Input.GetMouseButton(0))
    //        {
    //            direction = Vector3.up * jumpForce;
    //        }
    //    }
    //    character.Move(direction * Time.deltaTime);



}

