using Assignment1VT24;

namespace Assignment1VT24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SetUpConsoleWindow();

            // Create a poet object
            Pet petObj = new Pet();

            // call a method of the object to run
            petObj.Start();

            Console.WriteLine("\nPress Enter to start next part");
            Console.ReadLine();

            TicketSeller ticketSellerObj = new TicketSeller();
            ticketSellerObj.Start();


            Console.WriteLine("\nPress Enter to start next part");
            Console.ReadLine();

            Album albumObj = new Album();
             albumObj.Start();

            Console.WriteLine("\nPress Enter to start next part");
            Console.ReadLine();

            Library libraryObj = new Library();
            libraryObj.Start();

            



        }

        static void SetUpConsoleWindow()
        {
            // Arrange the Console Window
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();    
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "My Console Classes"; 
        }
    }

   
}
