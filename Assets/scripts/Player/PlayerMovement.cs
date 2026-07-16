using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public static float speed = 5f;
    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.aKey.isPressed)
        {
            if (transform.position.x - RoomMovement.room * 20 > -9)
            {
                transform.position -= new Vector3(Time.deltaTime * speed, 0, 0);
            }
         
            
        }
        if (Keyboard.current.dKey.isPressed)
        {
            if (transform.position.x - RoomMovement.room * 20 < 9)
            {
                transform.position += new Vector3(Time.deltaTime * speed, 0, 0);
            }
            
        }
    }
}
