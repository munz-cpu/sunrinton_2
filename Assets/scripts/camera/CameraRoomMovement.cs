using UnityEditor.SceneManagement;
using UnityEngine;

public class CameraRoomMovement : MonoBehaviour
{
    public int Room;
    public int currentStage;
    // Update is called once per frame
    void Update()
    {
        Room = RoomMovement.room;
        currentStage = RoomMovement.stage;
        transform.position = new Vector3(Room * 20, (1 - currentStage) * 15, transform.position.z);

        Debug.Log(Room);
    }
}
