using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public struct Card
{
    public string Name;
    public Sprite Logo;
    public int Attack;
    
    public Card(string name, string logopath, int attack)
    {
        Name = name;
        Logo = Resources.Load<Sprite>(logopath);
        Attack = attack;

    }

}

public static class CardManager { 
    public static List<Card> AllCards = new List<Card>();

}


public class CardManagerScripts : MonoBehaviour
{
    public void Awake()
    {
        CardManager.AllCards.Add(new Card("Skeleton", "Sprites/Cards/Skeleton", 4));
        CardManager.AllCards.Add(new Card("Skeleton", "Sprites/Cards/Vedma", 3)); 
    }



}
