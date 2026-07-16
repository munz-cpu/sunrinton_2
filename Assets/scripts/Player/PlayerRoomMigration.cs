using UnityEngine;


public class RoomMovement : MonoBehaviour
{
    public static int room = 0;
    public static int stage = 1;
    // Update is called once per frame
    void Update()
    {
        if (room < stage - 1)
        {
            if (transform.position.x - room * 20 >= 9)
            {
                room++;
                transform.position = new Vector3(room * 20 - 8, (1 - stage) * 15 - 1, 0);
            }
            if (room * 20 - transform.position.x >= 9)
            {
                room--;
                transform.position = new Vector3(room * 20 + 8, (1 - stage) * 15 - 1, 0);
            }
        }
            
    }
}
