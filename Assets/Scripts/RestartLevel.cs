using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    public void RestartGame()
    {
        // Cargar la escena llamada "main"
        SceneManager.LoadScene("main");
    }
}
