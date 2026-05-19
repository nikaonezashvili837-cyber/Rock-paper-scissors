namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {
            Move[] movesArray = [
                new Move{moveName = "Rock", beats = "Scissors"},
                new Move{moveName = "Scissors", beats = "Paper"},
                new Move{moveName = "Paper", beats = "Rock"},
            ];
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
    struct Move
    {
        public string moveName;
        public string beats;
    }
}