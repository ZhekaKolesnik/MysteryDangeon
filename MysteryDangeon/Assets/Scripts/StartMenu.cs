using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    [Header("Reference")]
    [SerializeField] private RectTransform menuContainer;

    [Header("Smooth")]
    [SerializeField] private bool smooth;
    [SerializeField] private float smoothSpeed = 0.1f;
    [SerializeField] private Vector3 desiredPosition;

    private Vector3[] menuPositions;

    private void Start()
    {
        //получить текущую позицию
        menuPositions = new Vector3[menuContainer.childCount];
        Vector3 halfScreen = new Vector3(Screen.width / 2, Screen.height / 2, 0);
        for (int i = 0; i < menuPositions.Length; i++)
        {
            menuPositions[i] = menuContainer.GetChild(i).localPosition;
        }
    }

    private void Update()
    {
        if (smooth)
        {
            menuContainer.anchoredPosition = Vector3.Lerp(menuContainer.anchoredPosition, desiredPosition, smoothSpeed);
        }
        else
        {
            menuContainer.anchoredPosition = desiredPosition;
        }
    }

    public void MoveMenu(int id)
    {
        desiredPosition = -menuPositions[id];
    }
}
