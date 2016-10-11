using System;
using System.Windows;

namespace ConsoleApplication
{
    public class Program
    {     

        public static void Main(string[] args)
        {

            //look in the player class and create a new variable called player1 and run the constructor method player
            Player player1 = new Player();
            Player player2 = new Player();

            Console.WriteLine("Hello Ashley!");
            Console.ReadLine();

            Console.Clear();
            player1.Draw();
            player2.Draw();

            while(true)
            {     
                //created a variable to hold our string for the switch case and assign them to key presses
                string direction = "";

                ConsoleKeyInfo keypress = Console.ReadKey(true);
                if(keypress.Key == ConsoleKey.UpArrow)
                {
                    direction = "up";
                }
                if(keypress.Key == ConsoleKey.DownArrow)
                {
                    direction = "down";
                }
                if(keypress.Key == ConsoleKey.LeftArrow)
                {
                    direction = "left";
                }
                if(keypress.Key == ConsoleKey.RightArrow)
                {
                    direction = "right";
                }

                //This runs the method for the direction clears the screen and redraws the players movement to the screen
                player1.Move(direction);
                Console.Clear();
                player1.Draw();
                player2.Draw();
            
            }
                Console.ReadKey(true);
            
        }
    }
}
