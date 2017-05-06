using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuActions : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MENU_ACTIONS_GoToScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }

    public void MENU_ACTIONS_QuitGame()
    {
        Application.Quit();
    }
}
