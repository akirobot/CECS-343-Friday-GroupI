using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterToEndTurn : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Return))
            transform.Rotate(Vector3.forward * 90);
	}

    public void BUTTON_ACTIONS_EndTurn()
    {
        transform.Rotate(Vector3.forward * 90);
    }
}
