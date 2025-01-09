using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class SingleCard : MonoBehaviour
{
    public Card CardValues;
    //public TMP_Text value;

    public Sprite[] Sprite;
    public Sprite[] Numbers;
    public Sprite[] Aces;

   // public SpriteRenderer back;
    public SpriteRenderer symbol;
    public SpriteRenderer number;
    public SpriteRenderer ace;
    /*  public Image symbol;
    public Image number;
    public Image ace;*/

    public void Start()
    {
        /*
        if (CardValues.FacingUp)
        {
            back.sortingOrder = 3;
        }
        else
        {
            back.sortingOrder = 0;
        }*/
        string val = "ace";

        if (CardValues.cardSuit == CardSuit.clubs)
        {
            symbol.sprite = Sprite[0];
            ace.sprite = Aces[0];
            number.color = new Color(0.2196079f, 0.1960784f, 0.1921569f);
        }
        else if (CardValues.cardSuit == CardSuit.diamonds)
        {
            symbol.sprite = Sprite[1];
            ace.sprite = Aces[1];
            number.color = new Color(0.3764706f, 0.1372549f, 0.1098039f);
        }
        else if (CardValues.cardSuit == CardSuit.hearts)
        {
            symbol.sprite = Sprite[2];
            ace.sprite = Aces[2];
            number.color = new Color(0.3764706f, 0.1372549f, 0.1098039f);
        }
        else
        {
            symbol.sprite = Sprite[3];
            ace.sprite = Aces[3];
            number.color = new Color(0.2196079f, 0.1960784f, 0.1921569f);
        }

        if (CardValues.cardValue == 1)
        {
            val = "ace";
            number.enabled = false;
            symbol.enabled = false;
            ace.enabled = true;
        }
        else if (CardValues.cardValue == 11)
        {
            val = "jack";
            number.sprite = Numbers[CardValues.cardValue];
        }
        else if (CardValues.cardValue == 12)
        {
            val = "queen";
            number.sprite = Numbers[CardValues.cardValue];
        }
        else if (CardValues.cardValue == 13)
        {
            val = "king";
            number.sprite = Numbers[CardValues.cardValue];
        }
        else
        {
            val = CardValues.cardValue.ToString();
            number.sprite = Numbers[CardValues.cardValue];
        }
            
        //value.text = (val +"\nof\n"+ CardValues.cardSuit.ToString());
    }
}
