using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUr.Console2
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();

            var playing = true;

            while (playing)
            {
                Console.ReadLine();
                game.Next();
                ShowField(game.Board.StartWhite);

            }
        }

        public static void ShowField(Field f)
        {
            var theString = "[";

            if(f.Piece != null)
            {
                theString += "x";
            }
            else
            {
                theString += " ";
            }

            theString += "]";
            Console.Write(theString);


            if (f.NextField != null)
            {
                ShowField(f.NextField);
            }

           
        }
    }
}
