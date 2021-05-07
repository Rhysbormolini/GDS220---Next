using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu, character;
    public GameObject endGame;

    void start()
    {
        //endGame.GetComponent<Renderer>();
        //endGame.enabled = false;
    }
    
    void update()
    {
        if (endGame.activeSelf)
        {
            character.SetActive(false);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

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
