
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler,IEndDragHandler
{

    public Transform parentToReturnTo = null;
    public RectTransform Card;

    void Start()
    {
        Card = GetComponent<RectTransform>();
    }


    public void OnBeginDrag(PointerEventData eventData)
    {

        Debug.Log("OnBeginDrag");
        parentToReturnTo = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
       // Debug.Log("OnDrag");
        this.transform.position = eventData.position;
       

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        this.transform.SetParent(parentToReturnTo);
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

    public void RotateCard()
    {
        Debug.Log("Entered Card");
        Card.Rotate(new Vector3(0, 0, 90));
        //if (Input.GetKeyUp(KeyCode.A))
        //{
        //    Card.Rotate(new Vector3(0, 0, 90));
        //    Debug.Log("Pressed A");
        //}
    }

}
