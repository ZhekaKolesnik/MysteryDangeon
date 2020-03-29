using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardMoveScripts : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    Camera MainCamera;
    Vector3 offset;
    public Transform DefaultBatya;

    void Awake ()
    {
        MainCamera = Camera.allCameras[0];

    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        offset = transform.position - MainCamera.ScreenToWorldPoint(eventData.position);
        DefaultBatya = transform.parent;

        transform.SetParent(DefaultBatya.parent);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        //throw new System.NotImplementedException();
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 newPos = MainCamera.ScreenToWorldPoint(eventData.position);
        transform.position = newPos + offset;
        

       //throw new System.NotImplementedException();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(DefaultBatya);
        GetComponent<CanvasGroup>().blocksRaycasts = true;


        //throw new System.NotImplementedException();
    }
}
