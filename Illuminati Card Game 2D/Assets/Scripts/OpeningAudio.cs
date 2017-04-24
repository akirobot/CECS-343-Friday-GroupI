using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningAudio : MonoBehaviour {

    // Use this for initialization
    new

    // Use this for initialization
    AudioSource audio;

    void Start () {
        audio = GetComponent<AudioSource>();
        //audio.time = 1.25f;
        audio.Play();
	}
	
	// Update is called once per frame
	void Update () {
        //if(audio.time > 9.50f)
        //{
        //    audio.Stop();
        //}
	}
}
