using UnityEngine;


public class RoomMovement : MonoBehaviour
{
    public static int room = 0;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x - room >= 9)
        {
            room++;
            transform.position = new Vector3(room * 20 - 8, transform.position.y ,0);
        }
        if (room - transform.position.x >= 9)
        {
            room--;
            transform.position = new Vector3(room * 20 + 8, transform.position.y, 0);
        }
    }
}
