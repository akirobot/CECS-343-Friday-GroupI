using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderAudio : MonoBehaviour {
    public Slider audioslider;

    //int x = audioslider.
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float volume = audioslider.value;
        AudioListener.volume = volume;
        Debug.Log(AudioListener.volume);
	}
}
