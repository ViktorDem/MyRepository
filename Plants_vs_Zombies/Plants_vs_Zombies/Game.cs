using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plants_vs_Zombies
{
    public abstract class Unit 
    {
      
    }
    public class Game
    {
        static int length = 10;
        static int width = 10;
        public int X { get; set; }
        public int Y { get; set; }
        Unit[,] arr = new Unit[length, width];
     
        public void Add(Unit unit)
        {
           
        }
        public void MoveUnit()
        {
            Y += -1;
        }
        public void Show()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0} ", arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
