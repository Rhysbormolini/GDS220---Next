using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject title, options, credits, control;

    // makes cursor useable after being in game
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    // Play the game 
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // open the options menu
    public void OptionsMenu()
    {
        title.SetActive(false);
        options.SetActive(true);
    }

    // close options menu
    public void CloseOptions()
    {
        title.SetActive(true);
        options.SetActive(false);
    }

    // open controls menu
    public void ControlMenu()
    {
        control.SetActive(true);
        options.SetActive(false);
    }

    // close controls menu
    public void CloseControl()
    {
        options.SetActive(true);
        control.SetActive(false);
    }

    // close credits menu
    public void CloseCredits()
    {
        title.SetActive(true);
        credits.SetActive(false);
    }

    // open credits menu
    public void CreditsMenu()
    {
        title.SetActive(false);
        credits.SetActive(true);
    }

    // quit the game
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
