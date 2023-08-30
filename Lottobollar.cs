
using System;

namespace Uppdrag3_Lottobollar
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hej och välkommen till Lotto!");
            Console.WriteLine("Skriv in 10 stycken tal mellan 1-25 så kollar vi om du får bingo!");

            int[] guess = new int[10];
            int[] randoms = new int[2];


            //Här har vi skapat två vektorer som lagrar heltal, en för gissning och en för slumptalen.

            for (int i = 0; i < guess.Length; i++)
            {
                string answer = Console.ReadLine();
                int guesses = Convert.ToInt32(answer);
                guess[i] = guesses;

                if (guesses < 0)
                {
                    Console.WriteLine("Detta var ett för lågt nummer!");
                    --i;
                }
                else if (guesses > 25)
                {
                    Console.WriteLine("Detta tal var för högt");
                    --i;
                }

            }
            // Här har vi gjort en for loop som går igenom gissningarna och och plussar med 1 så vektorn sparar alla index.
            // Dessutom konverterar vi talen till en int och skriver användaren under noll så kommer det att uppmärksammas samt om man skriver för högt tal.
            

            Random randomerare = new Random();
            int randomnumber_one = randomerare.Next(1, 25);

            Random random = new Random();
            int randomnumber_two = random.Next(1, 25);

            // Här skapar vi två slumptal. 

            bool isCorrect = false;
            // Här håller boolen koll på om man gissar rätt.
            // Den kollar om något av talen matchar slumpade talen här.
            for (int i = 0; i < guess.Length; i++)
            {
                Console.WriteLine("Talet du skrev in var :");
                Console.WriteLine("----> " + guess[i] + "");


                if (guess[i] == randomnumber_one || guess[i] == randomnumber_two)
                {
                    Console.WriteLine("Stort grattis! Du fick BINGO!");
                    isCorrect = true;
                }
            }
           
            Console.WriteLine("-------->  Rätta talen var " + randomnumber_one + " och " + randomnumber_two + " <--------");

            if (!isCorrect)
            {
                Console.WriteLine("Tyvärr det var fel, du fick ingen bingo");
            }
            // Här har vi gjort en till for loop som går igenom talen, samt skriver ut om de är rätt eller fel tal. 
        }
    }
}