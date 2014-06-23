using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Game
    {
        public void Run()
        {
          
            var aDeck = new Deck();
            var playerOne = new Hand();
            var playerTwo = new Hand();
            
            
            var poker = new GameRules();
            const int numberOfPlayers = 2;
            var gameWon = false;
            var pokerEvaluator = new Evaluator(PokerHandAnalysers.FiveCardPoker());
            aDeck.Shuffle();
            aDeck.Deal(playerOne);
            aDeck.Deal(playerTwo);


            
            


            while (!gameWon)
            {
                
                
                    for (int i = 0; i < numberOfPlayers; i++)
                    {

                        Console.WriteLine("Deck Cards:" + aDeck.Count());
                        Console.Write("Whose Turn: ");
                        if (i == 0)
                        {
                            Console.WriteLine("Player One");
                        }
                        else if (i == 1)
                        {
                            Console.WriteLine("Player Two");
                        }
                        Console.WriteLine("===Player One Hand===");

                        OutputCards(playerOne.GetCards());
                        Console.WriteLine("===Player Two Hand===");
                        OutputCards(playerTwo.GetCards());

                        var listOfHands = new List<Hand> { playerOne, playerTwo }; 
                        var result = pokerEvaluator.DetermineWinner(listOfHands);
                        if (result == playerOne)
                        {
                            Console.WriteLine("Player One Wins");
                        }else if (result == playerTwo)
                        {
                            Console.WriteLine("Player Two Wins");
                        }
                        else
                        {
                            Console.WriteLine("Draw");
                        }

                        Console.ReadKey();

                        //else if (//poker.CompareCards(player))

                        Console.WriteLine("D: Deal to Hand");
                        Console.WriteLine("S: Shuffle Deck");
                        Console.WriteLine("X: See Deck");
                        Console.WriteLine("R: Draw Cards");
                        Console.WriteLine("Escape: Quit");

                        var input = Console.ReadKey();

                        switch (input.Key)
                        {
                            case ConsoleKey.S:
                                aDeck.Shuffle();
                                break;
                            case ConsoleKey.D:
                                if (i == 0)
                                {

                                }
                                else if (i == 1)
                                {

                                }
                                break;
                            case ConsoleKey.R:
                                int cardsToReturn;

                                Console.WriteLine("How Many Cards?");
                                try
                                {
                                    cardsToReturn = int.Parse(Console.ReadLine());
                                }
                                finally
                                {

                                }
                                for (var j = 0; j < cardsToReturn; j++)
                                {
                                    Console.WriteLine(j);
                                }
                                Console.ReadKey();
                                if (i == 0)
                                {
                                    var cards = new List<int>();
                                    playerOne.ChangeCards(aDeck, cards);
                                    
                                }
                                else if (i == 1)
                                {
                                    var cards = new List<int>();
                                    playerTwo.ChangeCards(aDeck, cards);
                                }

                                break;

                            case ConsoleKey.Escape:
                                Environment.Exit(0);
                                break;
                            case ConsoleKey.X:

                                OutputCards(aDeck.GetCards());
                                Console.ReadKey();
                                break;
                        }
                        Console.Clear();
                    }
                

            }
        }

        public static void OutputCards(IEnumerable<Card> sentCards)
        {
            int i = 1;

           

            foreach (var aCard in sentCards)
            {
                var cardNumberValue = aCard.GetCardValue();
                

                var cardSuitValue = aCard.GetCardSuit();
                


                

                Console.WriteLine(cardNumberValue + " Of " + cardSuitValue);

                i++;
            }
            Console.WriteLine();



        }

        public static string AssignSuit(int suitValue)
        {
            switch (suitValue)
            {
                case 0:
                    return "S";
                case 1:
                    return "H";
                case 2:
                    return "C";
                case 3:
                    return "D";
                default:
                    return "X";

            }

        }

        public static void CheckForWin()
        {
            if (true)
            {
                
            }
        }
    }
}
