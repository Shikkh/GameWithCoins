using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameEnding movement;
    [SerializeField] private GameObject PausePanel;
    public float levelRestart = 2f;

    public void GameEnding()
    {
        movement.enabled = false;
        Invoke("RestartLevel", levelRestart);
    }
    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void BacktoMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void PauseButton()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ContinueButton()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
    }
}
