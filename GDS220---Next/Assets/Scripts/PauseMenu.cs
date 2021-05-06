using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu, character;

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        character.SetActive(true);
    }

    public void Quit()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
