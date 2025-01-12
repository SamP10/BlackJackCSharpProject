public class Card {
    private string suit;
    private string face;
    public int value;

    public Card(string suit, string face, int value) {
        this.suit = suit;
        this.face = face;
        this.value = value;
    }

    public string GetCard() {
        return $"{this.face} {this.suit}";
    }
}