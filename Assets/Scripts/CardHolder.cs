using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardHolder : MonoBehaviour
{
    public List<Card> Cards = new List<Card>();
    public List<Card> MixCards = new List<Card>();
    private CardSuit[] suits = { CardSuit.hearts, CardSuit.diamonds, CardSuit.clubs, CardSuit.spades };
    public int CardCount = 13;
    int x = 1;

    public void Awake()
    {
        for (int i = 0; i < CardCount; i++)
        {
            foreach (CardSuit suit in suits)
            {
                Cards.Add(new Card(x, suit,false));
            }
            if(x <13) 
                x++;
            else
                x = 1;
            //Debug.Log(Cards[i].cardValue.ToString() + " of " + Cards[i].cardSuit.ToString());
        }
        Debug.Log(Cards.Count);
    }
    public void RemoveCard(Card card)
    {
        Cards.Remove(card);
    }
}
