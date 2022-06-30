using System;

class ApiMarvel
{
    static void Main(string[] args)
    {
        string best = "Hello my besto friendo";
        string game = "Lets play a game?";
        string button = "Press Y to continue...";

        Console.WriteLine(best);
        Console.WriteLine(game);
        Console.WriteLine(button);

        string key = Console.ReadKey().Key.ToString().ToUpper();

        if (key == "Y")
        {
            Console.WriteLine();
            Console.WriteLine("Right Choise ma boyyy");
            Console.WriteLine("Tight, tight, tight... Yeah.");
            Console.WriteLine("So, question number one: what is my favorite food?");
            Console.WriteLine();
            Console.WriteLine("Letter A: Pizza");
            Console.WriteLine("Letter B: Lasagna");
            Console.WriteLine("Letter C: Lamen");
            Console.WriteLine();
            Console.WriteLine("Please Select your answer");

            string answer_1 = Console.ReadKey().Key.ToString().ToUpper();
            if (answer_1 == "C")
            {
                Console.WriteLine();
                Console.WriteLine("Impossible, what a monster bro? Right answer!!!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Oh, not this time =/");
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Ok, see you next time =/, bye...");
            Console.ReadLine();
        }

    }
}
