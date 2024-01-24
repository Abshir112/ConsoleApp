using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1VT24
{
    internal class Library
    {
        private string studentName; // Student borrowing the book
        private string libraryName; // Name of the library
        private string bookTitle; // Title of the book
        private DateTime borrowDate; // Date when the book was acquired
        private DateTime deadlineDate; // Date when the book is due to be returned
        private Random barcode; // Barcode of the book

        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to Central Library");

            ReadAndSaveLibraryData();
            DisplayLibraryInfo();
        }

        public void ReadAndSaveLibraryData()
        {
            // Read student's name
            Console.WriteLine("\nPlease enter your name? ");
            studentName = Console.ReadLine();

            // Read name of the library
            Console.WriteLine("What is the name of your registered library? ");
            libraryName = Console.ReadLine();

            // Read title of the book
            Console.WriteLine("What is the title of the book you want to borrow? ");
            bookTitle = Console.ReadLine();

            // Record borrowing date of the book
            borrowDate = DateTime.Now;
        }

        public void DisplayLibraryInfo()
        {
            Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++\n");

            Console.WriteLine("Checkouts:\n");
    
            Console.WriteLine($"Dear {studentName}!\n");
            Console.WriteLine($"Borrowing Date:  {borrowDate} you borrowed:\n");
            Console.WriteLine("Book Title: " + bookTitle);

            barcode = new Random();
            Console.WriteLine($"Barcode: {barcode.Next(100000000, 999999999)}");
            Console.WriteLine();

            deadlineDate = borrowDate.AddDays(21);
            Console.WriteLine($"Due date: {deadlineDate.ToString("yyyy-MM-dd")}");
            Console.WriteLine($"Please return the book to {libraryName} library before the due date.\n");

            Console.WriteLine("Best Regards\n");

            Console.WriteLine("Central Library");
            

            Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++\n");
        }
    }
}

