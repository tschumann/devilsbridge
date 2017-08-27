using System;

namespace devilsbridge
{
    public class AIPlayer : DevilsBridgePlayer
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
