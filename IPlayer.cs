public abstract class IPlayer {
    public Hand hand = new();

    public void AddCardToHand(Card card) {
        hand.AddCard(card);
    }
}