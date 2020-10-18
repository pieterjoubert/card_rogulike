using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class HandArray
{
    private Card[] hand;
    public HandArray(int current, int max)
    {
        hand = new Card[max];
    }
    public Card GetCard(int index)
    {
        return hand[index];
    }
}
