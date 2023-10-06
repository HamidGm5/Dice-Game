using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    internal class Program
    {
        static void Main()
        {
            char AgainWord; // Again Char We Give String for Have Strong Eror Manegment!

            Random myRand = new Random(Guid.NewGuid().GetHashCode());
            MyDice mdc = new MyDice();
            int mynumber = myRand.Next(1, 7);
            mdc.MYdice(mynumber);

            Random computeRand = new Random(Guid.NewGuid().GetHashCode());
            ComputerDice cdc = new ComputerDice();
            int compnumber = computeRand.Next(1, 7);
            cdc.COmputdice(compnumber);

            Result.result(mynumber, compnumber);

            Console.WriteLine("if You Would Play Again Press Button y And For Closing The Game Press Button n");

            AgainWord = Convert.ToChar(Console.ReadLine());
            again.againset(AgainWord);


            Console.ReadKey();
        }


        public class MyDice
        {
            private int _myDice = 0;

            public void MYdice(int md)
            {
                _myDice = md;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Your Dice = " + _myDice);
                Console.ResetColor();
            }

        }


        public class ComputerDice
        {
            private int _computerDice = 0;

            public void COmputdice(int cd)
            {
                _computerDice = cd;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Computer Dice = " + _computerDice);
                Console.ResetColor();
            }
        }


        public static class Result
        {
            public static void result(int my, int comp)
            {
                if (my > comp)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n" + "You Win!");
                    Console.ResetColor();
                }
                else if (my < comp)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n" + "You Lose!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n" + "Draw!");
                    Console.ResetColor();
                }
            }
        }


        public static class again
        {
            public static void againset(char ch)
            {
                if (ch == 'y' || ch == 'Y')
                {
                    Program.Main();
                }
                else if (ch == 'n' || ch == 'N')
                {
                    Console.WriteLine("Thanks For Playing !");
                }
                else
                {
                    Console.WriteLine("Not Corret value and i'm Closing Game !");
                }
            }
        }
    }
}