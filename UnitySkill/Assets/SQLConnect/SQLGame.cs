using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SQLGame : MonoBehaviour
{

    public Text playerDisplay;
    public Text scoreDisplay;

    private void Awake()
    {
        if (SQLDBManager.username == null)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("SQLMainMenu");
        }
        playerDisplay.text = "Player: " + SQLDBManager.username;
        scoreDisplay.text = "Score: " + SQLDBManager.score;
    }

    public void CallSaveData()
    {
        StartCoroutine(SavePlayerData());
    }

    IEnumerator SavePlayerData()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", SQLDBManager.username);
        form.AddField("score", SQLDBManager.score);

        WWW www = new WWW("http://localhost/sqlconnect/savedata.php", form);
        yield return www;

        if (www.text[0] == '0')
        {
            Debug.Log("Game Saved .");
        }
        else
        {
            Debug.Log("Save failed. Error #" + www.text);
        }

        SQLDBManager.LogOut();
        UnityEngine.SceneManagement.SceneManager.LoadScene("SQLMainMenu");
    }

    public void IncreaseScore()
    {
        SQLDBManager.score++;
        scoreDisplay.text = "Score: " + SQLDBManager.score;
    }
}
