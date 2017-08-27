using System;

namespace devilsbridge
{
    public class AIPlayer : Player
    {
        public AIPlayer(Card.IGame game) : base(game)
        {
            if (game == null)
            {
                throw new Exception();
            }
        }
    }
}
