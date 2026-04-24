using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 2f;

    public void CompleteLevel()
    {
        Debug.Log("Level Completed.");
        MainMenu();
    }

    public void EndGame()
    {
        Debug.Log("Game Over");
        Invoke("Restart", restartDelay);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
