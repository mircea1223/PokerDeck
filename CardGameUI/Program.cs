

BlackJackDeck deck =new BlackJackDeck();

var hand = deck.DealCard();

foreach (var card in hand)
{
    Console.WriteLine($"{card.Suit.ToString()} {card.Value.ToString()}");
}
