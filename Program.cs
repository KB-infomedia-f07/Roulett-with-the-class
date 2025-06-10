class Program {
    public static void Main(string[] args) {
        //TODO: create a working roulett program

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

                }
            
            }

            //ROULETTE HÄR

            rand.Next(0, 37);
            

                
        }
    }
}