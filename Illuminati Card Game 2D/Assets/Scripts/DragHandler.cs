using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject item;   
    public GameObject card;
    public Transform moveCard;

    void Start()
    {
        moveCard = card.GetComponent<Transform>();
    }

    Transform startParent;
    Vector3 startPosition;
    //bool start = true;
    //Sprite sprite;

    public void OnBeginDrag(PointerEventData eventData)
    {
        item = gameObject;
        startPosition = transform.position;
        //startParent = transform.parent;
    }


    public void OnDrag(PointerEventData eventData)
    {

        moveCard.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        moveCard.position = Input.mousePosition;
    }

}
