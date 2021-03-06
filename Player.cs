using System;
using System.Windows;

namespace ConsoleApplication
{
    public class Player
    {
        //set up the vairable for your constructor method
        char sprite;
        int xPosition;
        int yPosition;
        int health;
        int speed;
        ConsoleColor color = ConsoleColor.Gray; 

        public int XPosition
        {
            //A property is different to a variable because it has an accessor (get) and a mutator (set)
            get {return xPosition;}
            set {xPosition = value;}
            //Allows control of the variable, get without set returns a read only variable
        }

        public int YPosition
        {
            get {return yPosition;}
            set {yPosition = value;}
        }

        // create a constructor method for the blueprint of the object
        public Player()
        {
            sprite = '&';
            xPosition = 3;
            yPosition = 3;
            speed = 1;
        }

        //this is a constructor that takes 1 argument, polymorphism light
        public Player(char playerSprite) 
        {
            sprite = playerSprite;
            xPosition = 3;
            yPosition = 3;
            speed = 1;
        }

        public Player(char playerSprite, ConsoleColor color) 
        {
            sprite = playerSprite;
            xPosition = 3;
            yPosition = 3;
            speed = 1;
            this.color = color;
        }

        
        public void Draw()
        {
            Console.ForegroundColor = this.color;
            Console.CursorLeft = xPosition;
            Console.CursorTop = yPosition;
            Console.Write(sprite);
        }

        public void Move(string direction)
        {
            switch(direction)
            {
                case "up" : yPosition -= speed;
                break;

                case "down" : yPosition += speed;
                break;

                case "left" : xPosition -= speed;
                break;

                case "right" : xPosition += speed;
                break;

                default:
                break;
            }
        }
    }
 
}