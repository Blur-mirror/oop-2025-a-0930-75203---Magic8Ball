

using System;
using System.Collections.Generic;

class Magic8Ball
{
    static void Main()
    {
  

        List<string> myStrings = new List<string>()
        {
            "It is certain",
            "It is decidedly so",
            "Without a doubt",
            "Yes - definitely",
            "You may rely on it",
            "As I see it, yes",
            "Most likely",
            "Outlook good",
            "Yes",
            "Signs point to yes",
            "Reply hazy, try again",
            "Ask again later",
            "Better not tell you now",
            "Cannot predict now",
            "Concentrate and ask again",
            "Don't count on it",
            "My reply is no",
            "My sources say no",
            "Outlook not so good",
            "Very doubtful"
        };


        Console.WriteLine("Hello! Tell me your name\n");

        string userName = Console.ReadLine();

        bool keepPlaying = true; // Variable to control the game loop

        while (keepPlaying)
        {
            Random rand = new Random();

            int randomNumber = rand.Next(1, 21);

            string answerfromBall = myStrings[randomNumber - 1];

            Console.WriteLine("\nHello, " + userName + "!");
            Console.WriteLine("\nAsk me a yes or no question:\n");

            string userQuestion = Console.ReadLine();

            Console.WriteLine("\nYou asked: " + userQuestion);
            Console.WriteLine("\nThe Magic 8-Ball says: " + answerfromBall);

            Console.WriteLine("\nDo you want to ask another question? (yes/no)");
            string choice = Console.ReadLine().ToLower();

            if (choice == "no" || choice == "quit" || choice == "exit")
            {
                keepPlaying = false; // Exit the loop if the user doesn't want to continue
                Console.WriteLine("Thank you for playing! Goodbye, " + userName + "!");
            }

        }


        

    }
}