using System;
using System.Windows;
using System.Threading;

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
                if(Console.KeyAvailable)
                {
                    //created a variable to hold our string for the switch case and assign them to key presses
                    string direction = "";
                    string direction2 = ""; //added player2 directions seperately so included above if statemend underneath while loop ot refresh screen.

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
                     if(keypress.Key == ConsoleKey.W)
                    {
                        direction2 = "up";
                    }
                    if(keypress.Key == ConsoleKey.S)
                    {
                        direction2 = "down";
                    }
                    if(keypress.Key == ConsoleKey.A
                    {
                        direction2 = "left";
                    }
                    if(keypress.Key == ConsoleKey.D)
                    {
                        direction2 = "right";
                    }

                    //This runs the method for the direction clears the screen and redraws the players movement to the screen
                    player1.Move(direction);
                    player2.Move(direction2);
                }

                Console.Clear();
                player1.Draw();
                player2.Draw();

                Thread.Sleep(1000/60);
            }
        }
    }
}
