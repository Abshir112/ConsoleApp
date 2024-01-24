using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1VT24
{
    internal class Pet
    {
        private string name; // name of the pet
        private int age; // age of the pet
        private bool isFemale; // true if female, otherwise false

        public void Start()
        {
            Console.WriteLine(); //blankline
            Console.WriteLine("Greetings from the Pet class!\n");

            ReadAndSavePetData();
            DisplayPetInfo();

        }
        public void ReadAndSavePetData()
        {
            //Read name of the pet
            Console.WriteLine("What is the name of your pet? ");
            name = Console.ReadLine();

            //Record age of the pet
            Console.WriteLine($"What is {name}'s age? ");
            age = int.Parse(Console.ReadLine());

            //Check if the pet is female 
            Console.WriteLine("Is your pet a female (y/n)? ");
            string gender = Console.ReadLine().ToLower();

            char result = gender[0];

            if (result == 'y')
            {
                isFemale = true;
            }
            else
            {
                isFemale = false;
            }

        }

        public void DisplayPetInfo() 
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
            string info = "Name: " + name + " Age: " + age;
            Console.WriteLine(info);

            if (isFemale)
            {
                Console.WriteLine(name + ": She's such a wonderful pup!");
            }
            else 
            {
                Console.WriteLine(name + ": He's such a wonderful pup!");
                
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
        }
    }
}
