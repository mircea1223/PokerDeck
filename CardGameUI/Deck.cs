



public abstract class Deck
{


    protected List<PlayingCardModel> fullDeck = new List<PlayingCardModel>();

    protected List<PlayingCardModel> drawPile = new List<PlayingCardModel>();

    protected List<PlayingCardModel> discardPile = new List<PlayingCardModel>();
    protected void CreateDeck()
    {


        fullDeck.Clear();


        for (int col=0; col<4; col++)
        {
            for (int num = 0; num < 13; num++)
            {
                fullDeck.Add(new PlayingCardModel { Suit = (CardSuit)col, Value = (CardValue)num });
            }
        }
    }

    public virtual void ShuffleDeck()
    {
        var rnd = new Random();
        drawPile = fullDeck.OrderBy(x => rnd.Next()).ToList();
    }

    public abstract List<PlayingCardModel> DealCard();

    protected virtual PlayingCardModel DrawOneCard()
    {
        PlayingCardModel output = drawPile.Take(1).First();
        drawPile.Remove(output);
        return output;
    }
   
}
