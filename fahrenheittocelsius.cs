using System;

namespace Uppdrag2_Övning3
{
    class Program
    {

        public static double FahrToCel(int fahr)
        {

            double cel = (fahr - 32) * 5f / 9f;
            return cel;
            //Här gör vi en metod som tar in fahrenheit och omvandlar till celsius.
            //Först tar vi farenheit som en int och sedan omvandlar vi detta till en double variabel.
        }

        public static double InputToCelsius()
        {

            string fahrinput = Console.ReadLine();
            int fahr = 0;



            while (!int.TryParse(fahrinput, out fahr))
            {
                Console.WriteLine(" Skriv gärna in grader tack!");
                fahrinput = Console.ReadLine();
            }

            double cel = FahrToCel(fahr);
            return cel;
            // Med denna metod så använder vi oss utav en undantagshanetrings metod alltså en tryparse som ser till att vi får in ett tal som användaren skriver in.
            // Skulle användaren skriva in något som inte är en siffra så kommer denna att köras tills vi får in ett tal.
            // Vi har även anropat FahrToCel metoden som omvandlar farenheit till celsius. 
        }

        public static double FahrToCel()
        {
            Random fahrrandom = new Random();
            int fahr = fahrrandom.Next(1, 100);
            double cel = (fahr - 32) * 5f / 9f;
            return cel;
            // Här har vi gjort en metod-överlagring med FahrToCel som omvandlar farenheit till celsius.
            // Samt att det slumpas fram ett tal till användaren när denna metod körs.
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in den perfekta temperaturen till bastun i Fahrenheit tack!");
            double cel = InputToCelsius();
            // Här skriver användaren in fahrenheit som omvandlas till celsius tack vare metoden InputToCelsius.



            do // Här börjar loopen.
            {
                if (cel <= 0)
                {
                    cel = FahrToCel();
                    Console.WriteLine(" Du skrev in 0 vilket betyder att vi slumpade fram en grad i celsius till dig, graden blev "+ Math.Round(cel,2) +"");
                    cel = InputToCelsius();
                    // Denna if sats körs ifall användaren skriver in 0, jag la även till så det rundades upp med 2 decimaler
                    // Då det är mer korekt med utskrift av grader. Anvädaren får även försöka igen att skriva in en grad. 
                }

                else if (cel < 73)
                {
                    Console.WriteLine("Du skrev in "+ Math.Round(cel,2) + " Grader men detta blir för kallt, skriv in en ny grad.");
                    cel = InputToCelsius();
                    // Denna else if körs när användaren skriver in grader under 73, användaren får försöka igen.
                    // Det rundas även upp med två decimaler då det blir mer korekt när grader skrivs ut.
                    // Användaren får även försöka igen att skriva in en ny grad. 
                }
                else if (cel > 77)
                {
                    Console.WriteLine("Du skrev in " + Math.Round(cel,2) + " Grader. men nu vart det för varmt, testa igen!");
                    cel = InputToCelsius();
                    // Denna else if körs ifall grader är högre än 77, användaren får försöka igen.
                    // Det rundas även upp med två decimaler då det blir mer korekt när grader skrivs ut.
                    // Användaren får även försöka igen att skriva in en ny grad.
                }

            } while (cel < 73 || cel > 77);
            // Så länge det är under 73 och högre än 77 grader så kommer loopen att köras, när användaren väl skriver in 75
            // Eller 73 till 77 grader då kommer loopen att avslutas. 

            if (cel >= 75 && cel < 76)
            {
                Console.WriteLine("Du skrev in den perfekta graden på " + Math.Round(cel,2) + ", nu kan du basta!");
                // 75 grader var den perfekta graden, detta skrivs ut om användaren skriver in det.
                // Det rundas även upp med två decimaler då det blir mer korekt när grader skrivs ut.
                // Programmet avslutas här. 
            }

            else
            {
                Console.WriteLine("Du skrev ut " + Math.Round(cel,2) + " Detta är en godtagbar temperatur.");
                // Annars om användaren skriver grader mellan 73 - 77 så kommer detta att skrivas ut.
                // Det rundas även upp med två decimaler då det blir mer korekt när grader skrivs ut.
                // Programmet avslutas här. 
            }

            Console.ReadKey();

        }
    }
}