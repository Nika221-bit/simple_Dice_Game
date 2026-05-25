using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playRandomNum;
            int enemyRandomNum;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to Roll the dice");

                Console.ReadKey();
                playRandomNum = random.Next(1, 7);
                Console.WriteLine("you rolled a" + " " + playRandomNum);

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy rolled a" + " " + enemyRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);
               
              
            }
            

            Console.ReadKey();
        }
    }
  
}
