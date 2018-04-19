using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plants_vs_Zombies
{
    public interface UnitZombies
    {
       
        int Speed();
        char Show();
    }
    class BigZombie : UnitZombies
    {
        
        public int Speed()
        {
            return 50;
        }
        public char Show()
        {
            return 'B';
        }
    }
    class SmallZombie : UnitZombies
    {
        
        public int Speed()
        {
            return 100;
        }
        public char Show()
        {
            return 'S';
        }
    }
    class MiddleZombie : UnitZombies
    {
        
        public int Speed()
        {
            return 75;
        }
        public char Show()
        {
            return 'M';
        }
    }
}
