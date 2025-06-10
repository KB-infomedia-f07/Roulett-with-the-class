class Program
{
    public static void Main(string[] args)
    {
        //TODO: create a working roulett program

        int playerCash = 100;
        Random rand = new Random();
        int playerNumber = 0;
        int playerBet;
        string input = "";
        bool isPlaying = true;
        int roll;
        bool hasWon = false;
        string answer;

        while (isPlaying)
        {
            //Användaren skriver vilket nummer som den vill betta på
            Console.WriteLine("Type Bet HERE (1 - 36):\n");
            playerNumber = Convert.ToInt32(Console.ReadLine());
            //Hur mycket pengar på detta nmummret
            Console.WriteLine($"Type Amount of Cash! 10x Payout. (You have {playerCash})");
            playerBet = Convert.ToInt32(Console.ReadLine());
            playerCash -= playerBet;
            //Slumpa nummer
            roll = rand.Next(0, 37);
            //Win: 10x Payout
            if (roll == playerNumber)
            {
                playerCash += playerBet * 10;
                Console.WriteLine($"Du vann! Nu har du {playerCash}");
            }
            else //Loss Lose cash
            {
                playerCash -= playerBet;
                Console.WriteLine($"Du förlorade! Nu har du {playerCash}");
            }
            Console.WriteLine("Vill du spela igen? Ja/Nej");
            answer = Console.ReadLine();
          /*  if (answer.ToLower == "nej")
            {
                isPlaying = false;
                break;
            }
          */
            hasWon = false;

        }
    }

}


