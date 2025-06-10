using System.Data.SqlTypes;
using System.Runtime.InteropServices;

class Program
{
    public static void Main(string[] args)
    {
        Random rand = new Random();

        int money = 20;
        int bet = 0;
        string choice = "";
        Console.WriteLine("*You walk up to a casino, but realize you dont have any money since you blew it all on clash of clans gems*");
        Console.WriteLine("*Just then a shady individual walks up to you*");
        Console.WriteLine("Hello, it appears that you, sir, are indeed broke");
        Console.WriteLine("Could I perhaps interest you in putting a mortgage on your family?");
        Console.WriteLine("*You franticly shake your head up and down*");
        Console.WriteLine("Why thank you, here");
        Console.WriteLine("+$20");

        // Game Loop
        while (true)
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Bet on some numbers?");
            Console.WriteLine("2. Bet on a color");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                // Number
                while (true)
                {

                }
            }
            if (choice == "2")
            {
                // Color
                while (true)
                {

                }
            }
        }

        

    }
}