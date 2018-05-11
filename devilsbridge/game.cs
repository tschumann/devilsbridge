using System.Collections.Generic;

using Card;

namespace devilsbridge
{
    public class Game : Card.IGame
    {
        private List<ICardPlayer> players;
        private Deck deck;

        public Game(int playerCount)
        {
            this.deck = new Deck(this, false);
            this.players = new List<ICardPlayer>(playerCount);

            for (int i = 0; i < playerCount; i++)
            {
                this.players.Add(new DevilsBridgePlayer(this));
            }
        }

        public void deal()
        {
            this.deck.shuffle();
        }

        public List<ICardPlayer> getPlayers()
        {
            return this.players;
        }

        static void Main(string[] args)
        {
        }
    }
}
