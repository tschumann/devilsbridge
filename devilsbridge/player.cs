using System.Collections.Generic;

class Player : Card.ICardPlayer
{
    private List<Card.Card> hand;

    public Player()
    {
        this.hand = new List<Card.Card>();
    }

    public Card.Card play()
    {
        Card.Card card = null;

        // TODO: extend List to have a pop method?
        card = hand[0];
        hand.RemoveAt(0);

        return card;
    }

    public void receive(Card.Card card)
    {
        this.hand.Add(card);
    }
}