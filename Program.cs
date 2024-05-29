using System; 

namespace GuessTheNumberGame
{
    class Program 
    {
        static void Main(string[] args)
        {
            Random random = new Random(); 
            int correctNumber = random.Next(1, 101); 
            int guess = 0;

            Console.WriteLine("Welcome to the Guess the Number Game!");
            Console.WriteLine("I'm thinking of a number between 1 and 100. Can you guess what it is?");

            while (guess != correctNumber) 
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess)) 
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }

                if (guess < correctNumber) 
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (guess > correctNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else 
                {
                    Console.WriteLine("Congrats! You've guessed the correct number.");
                }
            }
        }
    }
}
