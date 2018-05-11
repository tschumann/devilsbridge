using System.Collections.Generic;

using Card;

namespace devilsbridge
{
    public class Game : Card.IGame
    {
        private int round;
        private Deck deck;
        private List<ICardPlayer> players;

        public Game(int playerCount)
        {
            this.round = 1;
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

        public void play()
        {
            List<ICard> cards = new List<ICard>();

            foreach(ICardPlayer player in this.players)
            {
                cards.Add(player.play());
            }

            round++;
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
