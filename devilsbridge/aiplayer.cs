using System;

class AIPlayer : Player
{
    public AIPlayer(Card.IGame game) : base(game)
    {
        if (game == null)
        {
            throw new Exception();
        }
    }
}