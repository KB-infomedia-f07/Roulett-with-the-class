class Program {
    public static void Main(string[] args) { 
        //TODO: create a working roulett program

        Random rand = new Random();
        int pengar = 1000;
        bool avsluta = false;
        bool betting = true;
     
        int val1;
        int val2;
        int val3;

        Console.WriteLine("Välkommen in! Sätt dig ner och spela en sväng roulette! Du KOMMER att förlora tillslut, bara så du vet!");

        while (pengar > 0 && avsluta != true)
        {
            Console.WriteLine("Så då, vad vill du göra?\n1. Nummer\n2. Färg\n 3. Jämn/Udda");
            while (betting == true)
            {
                val1 = Convert.ToInt32(Console.ReadLine());
                
            }
            
            

        }

        void AddBet(int bettedAmount)
        {
            //Det finns en klass "Bet" som denna funktionen ska skapa objekt med upp till 3.

        }
    }
}