using Systems;
using System.Windows;

namespace ConsoleApplication
{
    public class Player
    {
        //set up the vairable for your constructor method
        char sprite;
        int xPosition;
        int yPosition;

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
        }

        public void Draw()
        {
            Console.Write(sprite);
        }
    }
 
}