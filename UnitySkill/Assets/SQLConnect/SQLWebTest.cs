using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SQLWebTest : MonoBehaviour {



	// Use this for initialization
	IEnumerator Start () {
		WWW request = new WWW("http://localhost/sqlconnect/webtest.php");
        yield return request;
        string[] webResults = request.text.Split('\t');
	}
}
