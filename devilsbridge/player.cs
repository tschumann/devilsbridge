using System.Collections.Generic;

class Player : ICardPlayer
{
    private List<Card> hand;

    public Player()
    {
        this.hand = new List<Card>();
    }

    public Card play()
    {
        Card card = null;

        // TODO: extend List to have a pop method?
        card = hand[0];
        hand.RemoveAt(0);

        return card;
    }

    public void receive(Card card)
    {
        this.hand.Add(card);
    }
}