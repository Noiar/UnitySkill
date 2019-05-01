﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SQLLogin : MonoBehaviour
{

    public InputField nameField;
    public InputField passwordField;

    public Button submitButton;

    public void CallLogin()
    {
        StartCoroutine(Login());
    }

    IEnumerator Login()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", nameField.text);
        form.AddField("password", passwordField.text);
        WWW www = new WWW("http://localhost/sqlconnect/login.php", form);
        yield return www;

        if (www.text[0] == '0')
        {
            SQLDBManager.username = nameField.text;
            SQLDBManager.score = int.Parse(www.text.Split('\t')[1]);
            UnityEngine.SceneManagement.SceneManager.LoadScene("SQLMainMenu");
        }
        else
        {
            Debug.Log("user login failed. Error #" + www.text);
        }
    }

    public void VerifyInput()
    {
        submitButton.interactable = (nameField.text.Length >= 8 && passwordField.text.Length >= 8);
    }
}