public class Dealer : IPlayer {
    private Deck deck;

    public Dealer(Deck deck) {
        this.deck = deck;
        ShuffleDeck();
    }

    private void ShuffleDeck() {
        deck.cards = deck.cards.OrderBy( x => Random.Shared.Next()).ToList();
    }

    public Deck GetDeck() {
        return deck;
    }

    public Card Deal() {
        Card card = deck.cards[0];
        deck.cards.RemoveAt(0);  
        return card;
    }
}