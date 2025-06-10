class Program
{
    public static void Main(string[] args)
    {
    Random random = new Random();
    Console.WriteLine("Tjena! Välkommer till roulette!");
    
        Thread.Sleep(500);
    
    Console.WriteLine("Lägg ditt bett på ett nummer mellan 0 och 36!");
    string input = Console.ReadLine();


        if (int.TryParse(input, out int betNummer) && betNummer >= 0 && betNummer <= 36)
        {
            int vinnandeNummer = random.Next(0, 37);
            Console.WriteLine($"Det vinnande numret är: {vinnandeNummer}");

            if (betNummer == vinnandeNummer)
            {
                Console.WriteLine("Grattis! Du vann!");
            }
            else
            {
                Console.WriteLine("aJDÅ, du förlorade!");
            }
        }
    }
}