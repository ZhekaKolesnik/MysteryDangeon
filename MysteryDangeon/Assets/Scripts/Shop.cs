using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    private void OnMouseOver()
    {
        var rooms = FindObjectsOfType<Shop>();
        foreach (Shop room in rooms)
        {
            room.GetComponent<SpriteRenderer>().color = new Color32(130,130,130,255);
        }
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
