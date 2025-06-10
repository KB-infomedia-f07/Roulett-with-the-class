class Program {
    public static void Main(string[] args) {
        //TODO: create a working roulett program
        int number
        bool game = true;
        bool betting = true;
        string answer;
        int type;
        int color; //0 = svart, 1 = röd
        Random rand = new Random();
        while (game == true)
        {
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
                            Thread.Sleep(1500);
                            Console.Clear();
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