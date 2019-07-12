
// Let's say we have a class Deck()
// To create a new object of this class

Deck myDeck1 = new Deck();

// Print information about the deck status (full/ empty)
// "Empty" is a property of the Class Deck()

bool isDeckEmpty = myDeck1.Empty;
Console.WriteLine("Empty: " +  isDeckEmpty);

// OR we can access the property directly without assigning it to a variable
Console.WriteLine("Empty: " +  isDeckEmpty.Empty);

// when accessign a property we NEVER put () parenthesis

deck.Print();

//--------------------------------------
// tel the deck to shuffle itself
mydeck1.Shuffle(); // when accessing a method we always put () parenthesis

// cut the deck
myDeck1.Cut(26);

// Take the Top card --> Where Card is an object of another class
Card card1 = myDeck1.TakeTopCard();
Console.WriteLine(card1.Rank + " of " + card1.Suit); // Where Rank and Suit are properties of the Card Class