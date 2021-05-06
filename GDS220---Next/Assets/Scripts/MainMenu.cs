using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject title, options, credits;

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

    public void CloseOptions()
    {
        title.SetActive(true);
        options.SetActive(false);
    }

    public void CloseCredits()
    {
        title.SetActive(true);
        credits.SetActive(false);
    }

    public void CreditsMenu()
    {
        title.SetActive(false);
        credits.SetActive(true);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
