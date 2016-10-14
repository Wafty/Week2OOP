using System;
using System.Windows;
using System.Threading;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {     

        public static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

//look in the player class and create a new variable called player1 and run the constructor method player
            List<Player> players = new List<Player>();
            players.Add(new Player());
            
//Player player1 = new Player();  >>>commented out as using a list rather than setting variables
//Player player2 = new Player();

            Console.WriteLine("\n\nWelcome to our version of a Retro RPG");
            Console.WriteLine("Press any kep to continue");
            Console.ReadLine();

            

            Console.WriteLine("Please select your sprite by pressinga charachter key;");
            char playerSprite = Console.ReadKey().KeyChar;
            players.Add(new Player(playerSprite,ConsoleColor.DarkRed));

            Draw(players);

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
                    if(keypress.Key == ConsoleKey.A)
                    {
                        direction2 = "left";
                    }
                    if(keypress.Key == ConsoleKey.D)
                    {
                        direction2 = "right";
                    }

                    //This runs the method for the direction clears the screen and redraws the players movement to the screen
                    players[0].Move(direction);
                    players[1].Move(direction2);
                }

                Console.Clear();
                
                Draw(players);

                Thread.Sleep(30);
            }
        }

                public static void Draw(List<Player> players)
                {
                    foreach(Player player in players)
                    {
                        player.Draw();
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }                  
            }
        }