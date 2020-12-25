
using System;

namespace hc
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine(Str.RepeatCounter("adabadbadab", "ada"));
            string test = "abcd";
            
            Console.WriteLine(test.Halve());
            Console.WriteLine(Str.PalindromeOrNot(23336014));
            Console.WriteLine(Str.ReverseCase("Up And DowN TOo.!/?"));*/

            Alergy eggs = new Alergy("Eggs", 1);
            Alergy peanuts = new Alergy("Peanuts", 2);
            Alergy shellfish = new Alergy("Shellfish", 4);
            Alergy strawberries = new Alergy("Strawberries", 8);
            Alergy tomatoes = new Alergy("Tomatoes", 16);
            Alergy chocolate = new Alergy("Chocolate", 32);
            Alergy pollen = new Alergy("Pollen", 64);
            Alergy cat = new Alergy("Cat", 128);

            Alerged first = new Alerged("First", "firstPassEver");
            Alerged second = new Alerged("Second", "secondPassEver");
            Alerged third = new Alerged("Third", "thirdPassEver");
            Alerged fourth = new Alerged("Fourth", "fourthPassEver");
            //Alerged fifth = new Alerged("Fifth", "fifthPassEver");

            first.AddAlergy(eggs);
            first.LogIn("firstPassEver");
            first.AddAlergy(eggs);
            first.AddAlergy(eggs);
            first.Profile();
            Alerged.Profile(first);
            first.AddAlergy(cat);
            first.AddAlergy(pollen);
            first.AddAlergy(strawberries);
            first.Profile();
            first.AllAlergy();
            Alerged.TopAlergedPoints();
        }
    }
}
