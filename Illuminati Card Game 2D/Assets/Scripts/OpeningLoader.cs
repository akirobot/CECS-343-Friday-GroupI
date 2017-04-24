using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpeningLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine("CountDown");
	}
	
    private IEnumerator CountDown()
    {
        yield return new WaitForSeconds(10.25f);
        Application.LoadLevel(1);
        //SceneManager.LoadScene("Main Menu");
    }
}
