using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropPlaceScripts : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        CardScripts card = eventData.pointerDrag.GetComponent<CardScripts>();

        if (card)
        {
            card.DefaultBatya = transform;
        }

        //throw new System.NotImplementedException();
    }
}
