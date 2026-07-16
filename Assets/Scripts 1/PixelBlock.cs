using UnityEngine;

public class PixelBlock : MonoBehaviour

{

    Rigidbody2D rb;

    public bool attached = true;

    private void Awake()

    {

        rb = GetComponent<Rigidbody2D>();

        if(attached)

        {

            rb.bodyType =

                RigidbodyType2D.Static;

        }

    }

    public void BreakBlock()

    {

        attached = false;

        rb.bodyType =

            RigidbodyType2D.Dynamic;

    }

    public void TapeBlock()

    {

        rb.bodyType =

            RigidbodyType2D.Static;

    }

    private void Update()

    {

        if(Input.GetKeyDown(KeyCode.B))

        {

            BreakBlock();

        }

    }

}