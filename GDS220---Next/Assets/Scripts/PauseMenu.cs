using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu, character;
    public GameObject endGame;
    public float timer;

    void start()
    {
        //endGame.GetComponent<Renderer>();
        //endGame.enabled = false;
    }
    
    void update()
    {
        if (endGame.activeSelf)
        {
            StartCoroutine(EndTheGame());
            character.SetActive(false);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            //StartCoroutine(EndTheGame());
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

    IEnumerator EndTheGame()
    {
        timer = 10f;

        while (timer > 0)
        {
            timer -= Time.deltaTime;
            endGame.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            character.SetActive(false);
            yield return null;
        }

        if (timer <= 0)
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
}
