class Program
{
    public static void Main(string[] args)
    {
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
            if (playerCash <= 0)
            {
                Console.WriteLine("Du har inga pengar kvar! Spelet avslutas.");
                break;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|===================================================================================================|");
            Console.WriteLine("|                                                                                                   |");
            Console.WriteLine("|        :::::::::   ::::::::  :::    ::: :::        :::::::::: ::::::::::: ::::::::::: ::::::::::  |");
            Console.WriteLine("|       :+:    :+: :+:    :+: :+:    :+: :+:        :+:            :+:         :+:     :+:          |");
            Console.WriteLine("|      +:+    +:+ +:+    +:+ +:+    +:+ +:+        +:+            +:+         +:+     +:+           |");
            Console.WriteLine("|     +#++:++#:  +#+    +:+ +#+    +:+ +#+        +#++:++#       +#+         +#+     +#++:++#       |");
            Console.WriteLine("|    +#+    +#+ +#+    +#+ +#+    +#+ +#+        +#+            +#+         +#+     +#+             |");
            Console.WriteLine("|   #+#    #+# #+#    #+# #+#    #+# #+#        #+#            #+#         #+#     #+#              |");
            Console.WriteLine("|  ###    ###  ########   ########  ########## ##########     ###         ###     ##########        |");
            Console.WriteLine("|                                                                                                   |");
            Console.WriteLine("|===================================================================================================|");







            Console.WriteLine("Type Bet HERE (1 - 36):");
            playerNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Type Amount of Cash! 10x Payout. (You have {playerCash})");
            playerBet = Convert.ToInt32(Console.ReadLine());

            if (playerBet > playerCash || playerBet <= 0)
            {
                Console.WriteLine("Ogiltig insats. Försök igen.");
                continue;
            }

            playerCash -= playerBet;

            roll = rand.Next(0, 37);

            if (roll == playerNumber)
            {
                playerCash += playerBet * 10;
                Console.WriteLine($"Du vann! Nu har du {playerCash}");
            }
            else 
            {
                Console.WriteLine($"Du förlorade! Nu har du {playerCash}");
            }

            Console.WriteLine("Vill du spela igen? Ja/Nej");
            answer = Console.ReadLine();
            if (answer.ToLower() == "nej")
            {
                
                Console.WriteLine("Hejdå!");

                isPlaying = false;
                break;
            }

            hasWon = false;
        }
    }
}

