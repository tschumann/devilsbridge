using System.Collections.Generic;

class Player : IPlayer
{
    private List<Card> hand;

    public Card play()
    {
        Card card = null;

        // TODO: extend List to have a pop method?
        card = hand[0];
        hand.RemoveAt(0);

        return card;
    }
}