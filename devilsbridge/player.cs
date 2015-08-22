using System.Collections.Generic;

class Player : IPlayer
{
    private List<Card> hand;

    public Card play()
    {
        return hand[0];
    }
}