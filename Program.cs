using System;
using  ConsoleApp2.AnimalSpace;

namespace ConsoleApp2
{
    class MainEntryPoint
    {
        public int currentYear;
        public int yob;

         public static int FindAge(int currentYear, int yob)
        {
            return currentYear - yob;
        }

        static void Main(string[] args)
        {
            Animal human = new Animal();

            Console.WriteLine($"substracting variables: {human.currentYear - human.yob}");

           

            Console.WriteLine($"substracting variables inside a function: { human.FindAge(human.currentYear, human.yob)}");

            Console.WriteLine($"the name is: { human.showName("Mikol")}");

            Console.WriteLine($"multyply varibles: {human.dollars * human.shillings}");

            Console.WriteLine($"multyply variables inside a function: {human.Calculatecurrency( human.dollars , human.shillings )}");

            Console.WriteLine($"showfullname varibles:{human.showfullname(human.firstName, human.lastName)}");
        }
       
    

    }

}
