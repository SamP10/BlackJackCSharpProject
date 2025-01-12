public class Hand {
    public Card[] cards = [];
    private int handTotal = 0;

    public Hand() {

    }

    public void AddCard(Card card) {
        cards = cards.Append(card).ToArray();
        handTotal += card.value;
    }

    public override string ToString() {
        string handString = "";
        foreach(Card card in cards) {
            handString += card.ToString();
            handString += ", ";
        }
        handString += GetTotal();

        return handString;
    }

    public int GetTotal() {
        return handTotal;
    } 

    public bool IsBust() {
        return handTotal > 21;
    }
}