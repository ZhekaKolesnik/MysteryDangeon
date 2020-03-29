using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropPlaceScripts : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        CardMoveScripts card = eventData.pointerDrag.GetComponent<CardMoveScripts>();

        if (card)
        {
            card.DefaultBatya = transform;
        }
            
        //throw new System.NotImplementedException();
    }
}
