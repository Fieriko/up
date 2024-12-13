using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card 
{
    public int cardValue;
    public CardSuit cardSuit;
    public bool FacingUp;

    public Card(int cardValue, CardSuit cardSuit, bool facingUp)
    {
        this.cardValue = cardValue;
        this.cardSuit = cardSuit;
        FacingUp = facingUp;   
    }
}

public enum CardSuit
{
    hearts,
    diamonds,
    clubs,
    spades
}
public enum CardValue
{
    ace,two,three,four,five,six,seven,eight,nine,ten,jack,queen,king
}