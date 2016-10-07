using System;
using System.Windows;

namespace ConsoleApplication
{
    public class Program
    {
        //look in the player class and create a new variable called player1 and run the constructor method player
        Player player1 = new Player();      

        public static void Main(string[] args)
        {

            Console.WriteLine("Hello Ashley!");
            Console.ReadLine();

            Console.Clear();
            player1.Draw();

            Console.ReadKey(true);
        }
    }
}
