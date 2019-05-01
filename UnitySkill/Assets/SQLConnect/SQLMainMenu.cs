using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SQLMainMenu : MonoBehaviour
{
    public Button registerButton;
    public Button loginButton;
    public Button playerButton;

    public Text playerDisplay;

    private void Start()
    {
        if (SQLDBManager.LoggedIn)
        {
            playerDisplay.text = "Player: " + SQLDBManager.username;
        }

        registerButton.interactable = !SQLDBManager.LoggedIn;
        loginButton.interactable = !SQLDBManager.LoggedIn;
        playerButton.interactable = SQLDBManager.LoggedIn;
    }

    public void GoToRegister()
    {
        SceneManager.LoadScene("SQLRegisterMenu");
    }

    public void GoToLogin()
    {
        SceneManager.LoadScene("SQLLoginMenu");
    }

    public void GoToGame()
    {
        SceneManager.LoadScene("SQLGame");
    }
}
