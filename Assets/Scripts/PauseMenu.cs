using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuManager : MonoBehaviour
{
    public void ResumeGame()
    {
        SceneManager.UnloadSceneAsync("PauseMenu"); // Elt�vol�tja a PauseMenu jelenetet
        Time.timeScale = 1f; // Id� �jraind�t�sa
    }

    public void QuitToMainMenu()
    {
        Time.timeScale = 1f; // Id� vissza�ll�t�sa
        SceneManager.LoadScene("MainMenu"); // Visszat�r�s a f�men�be
    }
    public void GoToSettingsMenu()
    {
        SceneManager.LoadScene("SceneSettings");
    }
}
