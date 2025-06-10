class Program {
    public static void Main(string[] args) {
        //TODO: create a working roulett program
        int money = 100;
        int bet = 0;
        while (true)
        {
            Console.WriteLine("Do you want to");
            Console.WriteLine("(anything but 2). Gamble?");
            Console.WriteLine("2. Not gamble?");
            if (Console.ReadLine() == "2")
            {
                Console.Clear();
                continue;
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
                    catch
                    {

                    }
                }

            }
        }
    }
}