using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePlayerPrefs : MonoBehaviour {

    string key = "MyFirstKey";

    public int value;

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt(key, value);
        Debug.Log(PlayerPrefs.GetInt(key).ToString());
	}
}
