using System;

 namespace  ConsoleApp2.AnimalSpace {

    public class Animal
    {

        public string name = "Human";
        public string type = "mammal";
        public int legs = 2;
        public int yob = 1996;
        public int currentYear = 2021;
        public int dollars = 20;
        public int shillings=100;
        public string firstName = "michael";
        public string lastName = "mburu";
        public  int FindAge(int currentYear,int yob)
        {
            return currentYear-yob;
        }

        public string showName(string name)
        {
            return name;
        }
        public int Calculatecurrency( int dollar,int shilligs)
        {
            return dollars*shillings;
        }
        public string showfullname(string firstName, string lastName)
        {
            return string.Concat(firstName, lastName); 
        }
    }


}
