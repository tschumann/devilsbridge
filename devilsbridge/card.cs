
class Card
{
    enum Suit
    {
        SPADES = 0,
        DIAMONDS = 1,
        CLUBS = 2,
        HEARTS = 3,
    }

    enum Rank
    {
        TWO,
        THREE,
        FOUR,
        FIVE,
        SIX,
        SEVEN,
        EIGHT,
        NINE,
        TEN,
        JACK,
        QUEEN,
        KING,
        ACE,
        JOKER,
    }

    private Suit suit;
    private Rank rank;

    public Card(Suit suit, Rank rank)
    {
        this.suit = suit;
        this.rank = rank;
    }
}