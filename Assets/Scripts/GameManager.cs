using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int Score { get; set; }


    private bool gameHasEnded = false;
    public float restartDelay = 2f;
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            // Povikaj go ekranot za vnesuvanje na high score
            Invoke("Restart", restartDelay);
        }
    }

    public void Restart()
    {
        Score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
