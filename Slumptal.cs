using System;

namespace Del_Två
{
    class Program
    {
        static void Main(string[] args)
        {

            Random randomerare = new Random();
            int slump_tal = randomerare.Next(1, 100);

            Console.WriteLine("Nu ska vi slumpa fram ett tal mellan 1 och 100");


            Console.WriteLine("Gissa det magiska talet mellan 1-100");
            string indata;

            int siffra = 0;
            while (siffra != slump_tal)
                // Här körs loopen så länge användaren inte har skrivit rätt tal.
            {
                indata = Console.ReadLine(); // Här skriver användaren in gissningstalet "Slumptalet"
                if (!int.TryParse(indata, out siffra))
                //Denna utverdering bekräftar att vi får ut ett heltal,
                //Skulle användaren skriva något som inte innehåller en siffra så kommer utverderingen bli false
                //Därefter skrivs det ut "Du skrev fel" ut och de får försöka igen. 
                {
                    Console.WriteLine("Du skrev fel");
                }
                else
                {
                        if (siffra >= 101)
                        {
                            Console.WriteLine("Detta tal är för högt, var god försök igen"); // Här har användaren skrivt ett tal över 101 och då skriv detta ut
                        }
                        else
                        {
                            if (siffra < 1)
                            {
                                Console.WriteLine("Du skrev ett tal längre än 1"); // Här har användaren skrivit ett tal lägre än 1 
                            }
                            else
                            {
                                if (siffra > slump_tal)
                                {
                                    Console.WriteLine("Det är en för hög gissning"); // Här har användaren skrivit in ett tal högre än slumptalet
                                }
                                else
                                {
                                    if (siffra < slump_tal)
                                    { 
                                        Console.WriteLine("Det är en för låg gissning"); // Här har användaren skrivit in ett tal lägre än slumptalet
                                    }
                                    else
                                    {
                                        if (siffra == slump_tal)
                                            Console.WriteLine("Stooort grattis du skrev rätt!!!!! :D");
                                        
                                    }
                                }
                            }

                        }
                    
                    }
               
     
                }
            
        







            Console.ReadKey();
        }
    }
}
            