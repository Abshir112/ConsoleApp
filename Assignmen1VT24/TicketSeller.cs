using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1VT24
{
    internal class TicketSeller
    {
        // Fields - input 
        private string name;
        private double price = 100.0;
        private double childDiscount = 0.25;
        private int numOfAdults;
        private int numOfChildren;

        // Fields - output
        private double amountToPay;

        public void Start()
        {
            ReadInput();
            CalculateAmountToPay();
            ShowResults();


        }   

        private void ReadInput()
        {
            Console.WriteLine("Welcome to KID'S FAIR");
            Console.WriteLine("Children get always 75% discount!");
            Console.WriteLine();

            Console.WriteLine("Your name please!");
            name = Console.ReadLine();

            Console.WriteLine("Number of adults:");
            numOfAdults = int.Parse(Console.ReadLine());

            Console.WriteLine("Number of children:");
            numOfChildren = int.Parse(Console.ReadLine());

        }   


        private void CalculateAmountToPay()
        {
            amountToPay = numOfAdults * price + numOfChildren * price *  childDiscount;
        }

        private void ShowResults()
        {
            Console.WriteLine();
            
            Console.WriteLine("+++ Your receipt +++");
            Console.WriteLine("+++ Amount to pay = " + amountToPay);
            Console.WriteLine("+++ Price per ticket = " + price);
            Console.WriteLine($"+++ Thank you {name} and please come back! +++");
        }

    }
}
