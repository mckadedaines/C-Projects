using System;

<<<<<<< HEAD
=======
// public void Main {
//  Dealer();   
// }

// Deck d = new Deck();
// Console.WriteLine(d.Card_1());
// Console.WriteLine(d.Card_2());

public class Dealer {

}

public class Deck {

    public int Card1;
    public int Card2;

    public Deck(int Card1 = 0, int Card2 = 0) {
        this.Card1 = Card1;
        this.Card2 = Card2;
    }

    public int Card_1() {
        Random random = new Random();
        Card1 = random.Next(1, 13);

        return Card1;
    }

    
    public int Card_2() {
        Random random = new Random();
        Card2 = random.Next(1, 13);

        return Card2;
    }

}
>>>>>>> 88c27052463320aed3a71a53951bb3e81c048bc1
