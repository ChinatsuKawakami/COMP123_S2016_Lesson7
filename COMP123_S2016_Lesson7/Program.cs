using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); //pseudo number object
            List<int> diceRolls = new List<int>();//empty container    //for array , array is set instructor
            int[] tally = new int[13];



            int maxRolls = 50;
           // builds the list
            for (int index = 0; index < maxRolls; index++)
            {
                int firstDie = random.Next(1, 7);
                int secondDie = random.Next(1, 7);
                int dice = firstDie + secondDie; //min 2 ,max 12
                tally[dice]++;

                diceRolls.Add(dice);
                diceRolls.RemoveAt(0);
            }

            // sort List
            diceRolls.Sort();


            //display the list
            foreach(int result in diceRolls)
            {
                Console.WriteLine(result+" ");
            }

            Console.WriteLine();

            for(int index = 2;index<13;index++)
            {
                Console.WriteLine("{0}:{1} ",index,tally[index]);
            }
           

            /*Console.WriteLine("First: {0}",firstDie);
            Console.WriteLine("Second: {0}", secondDie);
            Console.WriteLine("Dice:{0}",dice);*/



        }
    }
}
