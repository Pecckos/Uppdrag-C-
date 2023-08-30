using System;

namespace Pension
{
    class Program
    {
        static void Main(string[] args)
        {
            int pensionAge = 65;
            Console.Write(" Hej, vad heter du för något fint? ");
            string firstName = Console.ReadLine();
            Console.Write(" Hejsan " + firstName);
            // Här tar jag in användarens namn och sparar i en variabel. 
            Console.Write(" Vad heter du i efternamn då? ");
            string lastName = Console.ReadLine();
            Console.Write(" Vilka fina namn du har, " + firstName + " " + lastName + "!");
            string tal = string.Empty;
            int age = 0;

            Console.Write(" \n Hörde att du börjar närma dig pensionsålder, hur gammal är du?\n");
            tal = Console.ReadLine();

            // TryParse försöker konvertera strängen in till ett tal, en bool som
            // säger om det gick bra att göra om strängen till en int eller inte
            // Om den blir sann, så slutar vi (genom !-operatorn), om den blir falsk
            // försöker vi igen.
            while (!int.TryParse(tal, out age))
            {
                Console.WriteLine(" Skriv gärna in ett tal tack! ");
                tal = Console.ReadLine();
            }

            if (age >= pensionAge)
            {
                Console.WriteLine(" Du har jobbat klart för denna livstid, vänligen gå och njut av livet " + firstName + " " + lastName + "!");
            }
            else if (age < 18)
            {
                Console.WriteLine(" Du har troligtvis inte börjat jobbat ännu, ett tips sov så mycket du kan ;) " + firstName + " " + lastName + "!");
            }
            else
            {
                Console.Write(" Då betyder det att det är endast " + (pensionAge - age).ToString() + " år kvar till din pension, simma lungt " + firstName + " " + lastName + "!");
            }
        }
    }
}