using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SinglePlayerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        //SceneManager.LoadScene("Illuminati");
        if (Input.GetMouseButtonUp(0))
            SceneManager.LoadScene("Illuminati");
    }

    //void OnMouseDown()
    //{
    //    Debug.Log("Pressed Singleplayer.");
    //    SceneManager.LoadScene("Illuminati");
    //}

}
