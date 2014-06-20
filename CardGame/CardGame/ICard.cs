namespace CardGame
{
    public interface ICard
    {
        Value GetCardValue();
        Suit GetCardSuit();
    }
}