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
            Console.WriteLine(welcomeScreen);
            byte userScore = 0, computerScore = 0;
            while (gameLoop)

            {
                string? input = Console.ReadLine();
                if (input == "X")
                {
                    break;

                }
                int idx = Convert.ToInt32(input);
                Random rnd = new Random();
                Move UserMove = movesArray[idx - 1];
                Move ComputerMove = movesArray[rnd.Next(0, movesArray.Length)];
                if (UserMove.beats == ComputerMove.moveName)
                {
                    userScore++;
                    Console.WriteLine(userScore);
                    Console.WriteLine("user score");
                }
                else if (ComputerMove.beats == UserMove.moveName)
                {
                    computerScore++;
                    Console.WriteLine(computerScore);
                    Console.WriteLine("computer score");
                }
                else
                {
                    Console.WriteLine(welcomeScreen);
                    continue;
                }
            }
        }
        struct Move
        {
            public string moveName;
            public string beats;
        }
    }
}