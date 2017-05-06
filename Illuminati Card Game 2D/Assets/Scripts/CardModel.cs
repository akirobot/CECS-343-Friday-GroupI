using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardModel : MonoBehaviour {
    //Initialize SpriteRender variable
    //Used for accessing SpriteRender Component in Awake method
    SpriteRenderer spriteRenderer;

    //Array of faces; data type Sprite
    //single back sprite
    public Sprite[] faces;
    public Sprite back;

    //index for showing which card face
    public int cardIndex;

    //Flipcard method
    public void flipCard(bool showFace)
    {
        if(showFace)
        {   //if true, display faces[cardIndex]
            spriteRenderer.sprite = faces[cardIndex];
        }
        else
        {   //else, display backside of card
            spriteRenderer.sprite = back;
        }
    }

    void Awake()
    {   //get SpriteRenderer Component
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
}
