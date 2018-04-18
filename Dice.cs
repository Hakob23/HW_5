using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_RollingDice
{
     class Dice
    {
        // creating delegate ' Message'
        public delegate void Message(String s);

        // creating instance events of delegate 'Message'
        public event Message twoSixed;      

        public event Message twentypassed;

     public void TossInRow(int num)
        {
            // Creating an array and filling it with simuntanpusly tossed numbers;
            int count = 0;

            int[] arr = new int[num];      

            for (int i = 0; i<num; i++)
            {
                 arr[i] = Toss();                               
            }

            // Checking if two consequent elements are 6;  calling the event; and counting the number of repeating cases;
            for(int i = 0; i < num-1; i++)
            {
                if(arr[i] == arr[i + 1] && arr[i] == 6)
                {
                    twoSixed("two sixes in a row");

                    count++;
                }
            }

            // Checking if the sum of 5 consequent elements are bigger than 20 and  calling th event;
            for(int i = 0; i <num - 5; i++)
            {
                if(arr[i]+arr[i+1]+arr[i+2]+arr[i+3]+arr[i+4] >= 20)
                {
                    twentypassed("sum passed 20");
                }
            }

            Console.WriteLine($"there were {count/2} two sixes in a row");
        }

     public int Toss()
        {
            Random r = new Random();

             
            int face = 0;

            // *Cycling with opposite direction on the dice's numbers,to make probabilities almost equal(If number divides by 4 and 2, it chooses 4, 6 and 3: 6 etc.)
            for (int i = 6; i>0; i--)
            {
                // Checking  which number  from  6-1 can divide randomly generated number;
                if ( r.Next() % i == 0)
                {
                    // If it does, face is getting the value of current i and program stops searchings;
                    face = i;
                    break;
                }
            }

            // returns the value;
            return face;
       }


    }
    
}
