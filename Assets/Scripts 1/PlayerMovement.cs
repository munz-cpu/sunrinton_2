using UnityEngine;

public class PlayerMovement : MonoBehaviour

{

    public float moveSpeed = 5f;

    public float jumpPower = 8f;

    private Rigidbody2D rb;

    private bool isGround;

    // 도구 사용 여부

    public bool isUsingTool = false;

    void Start()

    {

        rb = GetComponent<Rigidbody2D>();

    }

    void Update()

    {

        if (isUsingTool)

        {

            rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);

            return;

        }

        float move = Input.GetAxisRaw("Horizontal");

        rb.linearVelocity = new Vector2(move * moveSpeed, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && isGround)

        {

            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpPower);

        }

    }

    public void StartUsingTool()

    {

        isUsingTool = true;

    }

    public void EndUsingTool()

    {

        isUsingTool = false;

    }

    private void OnCollisionEnter2D(Collision2D collision)

    {

        if (collision.gameObject.CompareTag("Ground"))

        {

            isGround = true;

        }

    }

    private void OnCollisionExit2D(Collision2D collision)

    {

        if (collision.gameObject.CompareTag("Ground"))

        {

            isGround = false;

        }

    }

}