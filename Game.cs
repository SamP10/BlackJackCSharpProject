public class Game {
    Dealer dealer;
    Player player;
    public Game() {
        dealer = new(new Deck());
        player = new();
    }

    public void Run() {
        for(int i = 0; i < 2; i++) {
            player.AddCardToHand(dealer.Deal());
            dealer.AddCardToHand(dealer.Deal());
        }

        Console.WriteLine(player.hand.ToString());
        Console.WriteLine(dealer.hand.ToString());

        while (!player.hand.IsBust()) {
            Console.WriteLine("Hit Or Stick?");
            string hitOrStick = Console.ReadLine();

            if(hitOrStick == null | hitOrStick.ToLower() != "stick" && hitOrStick.ToLower() != "hit") {
                Console.WriteLine("Incorrect input");
                continue;
            }

            if (player.hand.GetTotal() == 21) {
                return;
            }

            if(hitOrStick.ToLower() == "stick") {
                break;
            }

            player.AddCardToHand(dealer.Deal());
            Console.WriteLine(player.hand.ToString());
        }

        if(player.hand.IsBust()) {
            Console.WriteLine("You Bust Out!");
            return;
        }

        if(player.hand.GetTotal() > dealer.hand.GetTotal()) {
            Console.WriteLine("You Won!");
        } else if (player.hand.GetTotal() == dealer.hand.GetTotal()) {
            Console.WriteLine("You Drew!");
        } else {
            Console.WriteLine("You Lost!");
        }
    } 
}