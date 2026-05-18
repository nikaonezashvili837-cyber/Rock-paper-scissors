namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {
            string welcomeScreen = @"
       ========================================
             ROCK PAPER SCISSORS
       ========================================

           Choose your move:

             [1] Rock
             [2] Paper
             [3] Scissors

             [X] Exit Game

           ---------------------------------------
           Enter your choice: ";
           bool gameLoop = true;
            while (gameLoop)
            {
                Console.WriteLine(welcomeScreen);
                string? input = Console.ReadLine();
                if(input == "X")
                {
                    break;

                }
            }
        }
    }
}