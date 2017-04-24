using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuMusic : MonoBehaviour {

    new AudioSource audio;

	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
        audio.time = 10.25f;
        audio.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
