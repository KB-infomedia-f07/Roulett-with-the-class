class Program {
    public static void Main(string[] args) {
        //TODO: create a working roulett program
        int number
        bool game = true;
        bool betting = true;
        int bet = 0;
        int currency = 500;
        string answer;
        int type;
        int color; //0 = svart, 1 = röd
        Random rand = new Random();
        while (game == true)
        {
            if (currency > 0)
            {
                Console.WriteLine("Ursäkta, du har inga pengar. Ut!")
                break;
            }

            Console.WriteLine("Du ser ett roulettebord");

            Console.WriteLine("Hur vill du gambla?\n1.Nummer\n2.Färg\n3.Jämn/Udda\nSVARA ENDAST MED NUMMER ANNARS KRASCH HAHAHAHAHHAHA");

            //Läs sigma
            while (betting == true) { 
            type = Convert.ToInt32(Console.ReadLine());


                //OLIKA TYPER AV BETTING
                switch (type)
                {
                    case 1:
                        Console.WriteLine("Vilket nummer vill du betta på?");
                        while (true)
                        {
                            number = Convert.ToInt32(Console.ReadLine());
                            try
                            {
                                if (number >= 37 || number < 0)
                                {
                                    Console.WriteLine("Ogiltigt nummer");
                                }
                                else
                                {
                                    break;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Endast giltiga nummer tillåts");
                            }
                            Console.WriteLine("Du har valt nummret {0}", number);
                            Thread.Sleep(500);
                            Console.Clear();
                        }

                        while (true)
                        {
                            Console.WriteLine("Hur mycket pengar vill du sätta på numret {0}?", number);
                            try
                            {
                                if (bet < currency)
                                    Console.WriteLine("Ogiltigt bet, du kan inte sätta mer pengar än vad du har");
                                else if (bet >= 0)
                                {
                                    Console.WriteLine("Du kan inte sätta mindre pengar än vad du har. Du kan inte heller sätta 0");
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Ogiltigt nummer");
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("Vilken färg vill du betta på?");
                        while (true)
                        {
                            answer = Console.ReadLine();
                            if (answer.ToLower() == "röd")
                            {
                                color = 1;
                            }
                            else if (answer.ToLower() == "svart")
                            {

                            }
                            else
                            {
                                Console.WriteLine("Du har skrivit fel input på något vis. Försök igen");
                            }
                            
                        }
                        break;
                }
            
            }

            //ROULETTE HÄR

            rand.Next(0, 37);
            

                //test
        }
    }
}