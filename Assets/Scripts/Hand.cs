using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public List<Card> handList = new List<Card>();
    public CardHolder deck;
    public int HandDraw;

            int placeSet = 0;
    float placeOffset = 0;

    public GameObject GivenCard;
    public Transform[] Place;

    public void Start()
    {
        for (int i = 0; i < HandDraw; i++)
        {
            DrawCard();
        }
    }
    public void DrawCard()  //draw a card from the deck and add it to the hand
    {
        //for(int i = 0; i < HandDraw; i++)
        // {
        if (placeSet == Place.Length)
        {
            placeOffset = placeOffset + .5f;
            placeSet = 0;
        }
            GameObject card = Instantiate(GivenCard, new Vector3(Place[placeSet].position.x, Place[placeSet].position.y + placeOffset, Place[placeSet].position.z), Quaternion.identity, Place[placeSet]);
            placeSet++;

            int selected = Random.Range(1,deck.Cards.Count);

            Card selectedCard = deck.Cards[selected];
            card.GetComponent<SingleCard>().CardValues = selectedCard;
           // Debug.Log(selectedCard.cardValue.ToString() + " of " + selectedCard.cardSuit.ToString());
            handList.Add(selectedCard);
            deck.RemoveCard(selectedCard);
           // Debug.Log(deck.Cards.Count);
       // }
    }
}
