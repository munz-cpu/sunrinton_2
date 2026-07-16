using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{

    public void LoadNextScene()
    {
        SceneManager.LoadScene("Room");
    }
}
