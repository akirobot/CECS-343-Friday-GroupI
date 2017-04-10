using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Script To Flip Card when pressing Left MB.
 * Currently flips on click on anylocation
 * 
 * TODO: Implement flip on click iff mouse hover is on Card GameObject
 */

public class DebugFlipCard : MonoBehaviour {

    //initialize variables
    CardModel cardModel;
    int cardIndex = 0;
    public GameObject card;

    //initializes before Game instance
	void Awake()
    {   //get Card Component
        cardModel = card.GetComponent<CardModel>();
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(0))
        {   //flip card on Left MB Click
            cardModel.flipCard(true);
        }
	}
}
