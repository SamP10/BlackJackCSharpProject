public class Dealer {
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
}