# battle-of-cards-niepokorni


**Requirements**

● Select a ​theme ​for your card game​. A few popular choices are cars, fighter jets,dinosaurs, football teams, actors, etc. ​Use your imagination!

● Define your game’s rules​. How many players? How many cards dealt per players? Doyou want to allow bets?

● Model your game​ using interfaces, classes, etc.
 
● Use ​abstraction, inheritance, composition and encapsulation​ where applicable.

● Implement the ​Comparable ​interface and create and use a ​Comparator ​implementationat least once.

● Implement the ​hashCode ​and ​equals ​methods at least on one class.

● Implement ​toString​ on classes where it makes sense to pretty print them to the terminal.

● Print to the standard output ​only​ in a single place in your application​ (seeprintStatistics​ in ​Step 4​).

● Use the ​Collections framework​ for your implementation.

● Use Git​ to version your application’s source code - commit frequently and small,well-defined changes.

● Create a Main class, with a ​main​ method.


Don’t panic! Look at the ​Modelling Walkthrough​ below.
One more thing: ​You cannot use static variables or methods​​(except the ​main​ method).Create instances of your classes instead.


**Modelling Walkthrough**

The following steps will walk you through the “modelling” of Blackjack.This is just a rough example, you need to model your own game on your own. Thinkbefore coding!


*Step 1.1*

Think about the game. How do people play blackjack at a casino? ​
List the things that come to mind thinking about ​walking into a casino to play blackjack​.
● Casino
● Table
● Player
● Dealer
● Deck ​of cards
● Hand ​of cards
● Card
● Bet
● Placing bets
● Dealing cards
● Keeping hand (stand), ​drawing more cards​ (hit or bust)
● End game
● Raking in winnings
● etc.

Choose things to model​. There’s ​no need to model ​everything​ - just the bare minimumwhich seems necessary to build the game.In the above list nouns are in ​bold​, verbs are ​underlined and italic​. Nouns will representclasses, interfaces, verbs will represent methods.


*Step 2.1*

Modelling can be approached in several ways. Two of these are ​top-to-bottom​ or ​bottom-up​. Itdoesn’t matter which one you choose, experiment and see which way works for you better. Forthis blackjack game we’ll start with a bottom-up approach.

First. What is at ​the ​core​ of blackjack​? You guessed it, ​cards​!​ Let’s model a card and create aclass for it.
First of all. ​Pick up a card​, take it into your hards. ​Examine it!
If you examine more cards you’ll ​recognize the ​pattern​ which are followed by all cards.Each card has●a ​rank​ (a value like 10),
● a suite (like Spades),
● and a ​state​ (face up, face down, etc).

Values like these (finite, countable non-changing things like possible suites of a card) are bestmodelled with ​Java enums​.


*Step 2.2*

Based on this we’ll create our ​Card​ class ​... and at the same time we’ll define some ​moreclasses ​which are based on or using ​Card​s. Like a ​Deck​ which consists of a list of 52 cards,and a ​Hand​ (cards held by a player) which consists of 2 or more cards.
Calling ​toString​ on a Card or a Hand returns the String representation of a Card or a Hand foreasier debugging.


*Step 2.3*

The Card class ​implements ​the ​Comparable​ interface provided by Java. Making Card instancescomparable to each other.Card card1 = ...Card card2 = ...card1.compareTo(card2)This could be used to order cards naturally in a Deck. E.g. in a fresh pack of cards cards couldbe ordered like, Ace of Spades, Spades 1, Spades 2, ..., King of Diamonds.


*Step 2.4*

Hand ​instances are compared using an instances of the ​HandComparator​ class.
The ​HandComparator​ implements the ​Comparator​ interface. It could be used to evaluateplayers’ hands against the dealer’s hand of cards to see who wins.


*Step 3.1*

During a game of blackjack who’re going to use these cards? Players of the game obviously.Let’s model the concept of a ​Player​ with an ​interface​.

Step 3.1During a game of blackjack who’re going to use these cards? Players of the game obviously.Let’s model the concept of a ​Player​ with an ​interface​.Player in the context of blackjack is ambiguous. The dealer is playing too, right? However eachplayer is dealt cards. Let’s call a ​player playing against the house, the casino a ​Patron​. Theplayer representing the casino will be a ​Dealer.Patrons and the dealer shares some behaviour. Both of these players have●a ​hand of cards​,●and can ​decide to stand or hit​ (draw more cards or stop).However a ​Dealer​ also can ​deal cards​ to players (to add a Card to their Hand) -dealTo(Player)​. Dealers will be able to ​deal cards to themselves​ (​Dealer​ extends the ​Playerinterface for this purpose).A ​Patron​ cannot deal cards, but s/he can ​place bets and cash in winnings​ (and also has abalance).


*Step 3.1*

During a game of blackjack who’re going to use these cards? Players of the game obviously.Let’s model the concept of a ​Player​ with an ​interface​.Player in the context of blackjack is ambiguous. The dealer is playing too, right? 
However eachplayer is dealt cards. Let’s call a ​player playing against the house, the casino a ​Patron​. Theplayer representing the casino will be a ​Dealer.

Patrons and the dealer shares some behaviour. Both of these players have
● a ​hand of cards​,
● and can ​decide to stand or hit​ (draw more cards or stop).

However a ​Dealer​ also can ​deal cards​ to players (to add a Card to their Hand) -dealTo(Player)​. Dealers will be able to ​deal cards to themselves​ (​Dealer​ extends the ​Playerinterface for this purpose).

A ​Patron​ cannot deal cards, but s/he can ​place bets and cash in winnings​ (and also has abalance).

Concrete realizations of these concepts could be ​BlackjackPlayer ​and ​BlackjackDealer​ sharinga common ancestor class ​AbstractPlayer​.


*Step 4.1*

Going ahead we’ll model a ​blackjack table​. If you think about it you can come up with theproperties of a ​Table​.
● Patron​s can sit there,
● it has one ​Dealer​,
● and at least a ​Deck​ of cards.And of course ​the game is played at the Table​.Based on this Let’s model a ​Table​.


*Step 4.2*

Calling ​playRound​ will simulate a game of blackjack. It can throw a ​GameException​ if somethinghappens while simulating a round of blackjack. E.g. if there are no Patrons sitting at the table itcould throw an error saying “no players sitting at the table, game cannot be played”.

A pseudo-code for this method would look like this.

    public void playRound() throws GameException {        
        patronsBet();        
        dealerDeals();        
        patronsTurn();
        dealerTurn();        
        evaluateRound();  }

    The methods used here could be ​private​ methods of a hypothetical implementation. Eachmethod simulating some part of the game.
    
    
*Step 4.3*

 Pseudo-code for the ​patronsBet​ would look like this.
 
    private void patronsBet() {    
        for (Patron patron : patrons) {        
            bets.put(patron, patron.getBet());    }}
            
       
*Step 4.4*

Calling ​printStatistics ​should print the current status of our blackjack table to standard output:info about the patrons sitting at the table, the current hands, bets placed, etc.


*Step 5.1*

Now that we’ve modelled almost every concept/thing that someway or another participates inour blackjack game we have to ​define our program’s main entry point​, the ​Main​ class alongwith the ​main​ method.

The pseudo-code for this would look like this.

    public static void main(String[] args) throws GameException {   
        Deck deck = ...   Dealer dealer = ... // dealer is using the Deck instance   Iterable<Patron> patrons = ...   
        Table table = new BlackjackTable(dealer, patrons);   
        table.playRound();   
        table.printStatistics();  }




**Summary**

Based on the above ​Steps​ which outline the modelling of Blackjack ​create your own game!You’re completely free to ​create your own interfaces, abstract classes and ​concrete classes​ toimplement the game. The UML diagrams above are giving you only a rough outline and by nomeans the only way to implement a game, or to organize classes.Once again, ​you’re free to experiment, but ​keep the Requirements in mind!
