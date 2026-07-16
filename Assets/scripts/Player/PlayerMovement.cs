using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.aKey.isPressed)
        {
            transform.position -= new Vector3(Time.deltaTime * speed, 0, 0);
        }       
        if (Keyboard.current.dKey.isPressed)
        {
            transform.position += new Vector3(Time.deltaTime * speed, 0, 0);
        }
    }
}
