using System;
using System.Xml;

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
            var birdVulture = new Bird();
            birdVulture.Name = "Paul!";
            birdVulture.TailLength = 12;
            birdVulture.BeakColor = "White!";
            birdVulture.FeatherColor = "Black";
            birdVulture.IsPredatory = true;

            Console.WriteLine($"Name: {birdVulture.Name}\n Beak Color: {birdVulture.BeakColor}\n Feather Color: {birdVulture.FeatherColor}\n Are they predatory? {birdVulture.IsPredatory}");
            /*Create an object of your Reptile class
            *  give values to your members using the object of your Reptile class
            *  
            * Creatively display the class member values 
            */
            var reptileKomodoDragon = new Reptile();
            reptileKomodoDragon.Name = "Louise";
            reptileKomodoDragon.HasLegs = true;
            reptileKomodoDragon.HumanKillsPerYear = 5;
            reptileKomodoDragon.IsSnake = false;
            reptileKomodoDragon.IsDangerous = "Heck Yeah! pfft";


            Console.WriteLine($"Name: {reptileKomodoDragon.Name}\n Has Legs: {reptileKomodoDragon.HasLegs}\n Human Kills Per Year: {reptileKomodoDragon.HumanKillsPerYear}\n Is A Snake: {reptileKomodoDragon.IsSnake}\n Are they dangerous? {reptileKomodoDragon.IsDangerous}");
            
        }
    }
}
