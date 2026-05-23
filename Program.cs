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
                if (userScore >= movesArray.Length || computerScore >= movesArray.Length)
                {
                    CheckWinner(userScore, computerScore);
                }
                if (idx > movesArray.Length)
                {
                    Console.WriteLine("Invalid number");
                    Console.WriteLine(welcomeScreen);
                    continue;
                }
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
        public static void CheckWinner(byte userScore, byte computerScore)
        {
            string userWonMessage = @"
            ====================================
            YOU ARE VICTORIOUS
            ====================================
            The computer has been defeated.
            Your move was superior.
            ====================================";
            string computerWonMessage = @"
            ====================================
            COMPUTER WINS
            ====================================
            The machine outplayed you.
            Better luck next round.
            ====================================";
            string tieMessage = @"
            ====================================
            DRAW
            ====================================
            Both sides chose equally well.
            No winner this round.
            ====================================";
            if (userScore > computerScore)
            {
                Console.WriteLine(userWonMessage);
            }else if(computerScore > userScore)
            {
                Console.WriteLine(computerWonMessage);
            }
            else
            {
                Console.WriteLine(tieMessage);
            }
        }
        struct Move
        {
            public string moveName;
            public string beats;
        }
    }
}