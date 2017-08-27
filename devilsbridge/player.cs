using System;

namespace devilsbridge
{
    public class Player : Card.AbstractCardPlayer
    {
        public Player(Card.IGame game) : base(game)
        {
            if (game == null)
            {
                throw new Exception();
            }
        }

        public override Card.Card play()
        {
            Card.Card card = null;

            // TODO: extend List to have a pop method?
            card = hand[0];
            hand.RemoveAt(0);

            return card;
        }

        public override Card.Card swap(Card.Card card)
        {
            // TODO: does this game have swapping?
            throw new System.NotImplementedException();
        }
    }
}
