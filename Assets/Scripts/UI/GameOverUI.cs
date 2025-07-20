using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    public void Retry()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void QuitToMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}