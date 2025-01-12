public class Deck {
    public List<Card> cards = new List<Card>();
    private string[] suits = ["♣️", "♠️", "♥", "♦"];
    private Dictionary<string, int> numbers = new Dictionary<string, int>(){
        {"Ace", 1}, 
        {"Two", 2},
        {"Three", 3},
        {"Four", 4},
        {"Five", 5},
        {"Six", 6},
        {"Seven", 7},
        {"Eight", 8},
        {"Nine", 9},
        {"Ten", 10},
        {"Jack", 10},
        {"Queen", 10},
        {"King", 10}
    };

    public Deck() {
        CreateCards();
    }

    private void CreateCards() {
        foreach (KeyValuePair<string, int> number in numbers) {
            foreach (string suit in this.suits) {
                cards.Add(new Card(suit, number.Key, number.Value));
            }
        }
    }
}