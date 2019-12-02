using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebTest : MonoBehaviour
{
     IEnumerator Start()
     {
          WWW request = new WWW("http://localhost/sqlconnect/webtest.php");
          yield return request;
          string[] webResults = request.text.Split('\t');
          Debug.Log(webResults[0]);
          int.Parse(webResults[1]);
     }
}
