using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var bird1 = new Bird();
            
                bird1.Age = 20;
                bird1.Legs = 2;
                bird1.IsExtinct = true;
                bird1.NoiseMade = "Caw";
                bird1.FeatherColor = "Brown";
                bird1.Birdtype = "Raptor";
                bird1.WingLength = 23;
                bird1.IsBirdofPrey = true;
            
            bird1.printDetail();
            Console.WriteLine("---------------------------------------------");

            var reptile1 = new Reptile(250, 4, true, "Meh", "green",8, false, false);

            reptile1.printDetail();




            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
