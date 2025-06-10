class Program {
    public static void Main(string[] args) {
        //TODO: create a working roulett program
        Random rand = new Random();

        bool hasMoney = true;
        int money = 100;
        int bet = 0;

        while (hasMoney = true)
        {
            Console.WriteLine("Do you want to");
            Console.WriteLine("(anything but 2). Gamble?");
            Console.WriteLine("2. Not gamble?");
            if (Console.ReadLine() == "2")
            {
                Console.Clear();
                continue;
            }

            if (money < 0)
            {
                Console.WriteLine("Uh oh...You are out of money. You CANT GAMBLE! GET OUT!");
                Thread.Sleep(2500);
                hasMoney = false;
                break;
            }
            while (true)
            {
                Console.WriteLine("Enter your bet");
                while (true)
                {
                    try
                    {
                        bet = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("You can only write a number that is your balance or lower");
                    }
                    money = money - bet;
                    break;
                }



            }
        }
    }
}