using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_RollingDice
{
    class Program
    {
        static void Main(string[] args)
        {

            Dice d = new Dice();

            d.twoSixed += Message;
            d.twentypassed += Message;

            d.TossInRow(50);


            Console.Read();

        }

        public static void Message(string s)
        {
            Console.WriteLine(s);
        }
    }
}
