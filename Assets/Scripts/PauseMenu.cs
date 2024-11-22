using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipController : MonoBehaviour
{
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0f; // Meg�ll�tja az id�t
        SceneManager.LoadScene("PauseMenu", LoadSceneMode.Additive); // Addit�v bet�lt�s
        isPaused = true;
    }

    void ResumeGame()
    {
        Time.timeScale = 1f; // Id� vissza�ll�t�sa
        SceneManager.UnloadSceneAsync("PauseMenu"); // PauseMenu Scene elt�vol�t�sa
        isPaused = false;
    }
}
