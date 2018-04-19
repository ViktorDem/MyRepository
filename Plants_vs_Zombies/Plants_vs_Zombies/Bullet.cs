using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plants_vs_Zombies
{
    public interface Bullet
    {
        int Speed();
        char Show();
    }

    class CactusBul : Bullet
    {
        
        public int Speed()
        {
            return 400;
        }
        public char Show()
        {
            return '-';
        }

    }
    class AzaleaBul : Bullet
    {
        public int Speed()
        {
            return 200;
        }
        public char Show()
        {
            return '*';
        }
    }
    class RoseBul : Bullet
    {
        public int Speed()
        {
            return 200;
        }
        public char Show()
        {
            return '>';
        }
    }
}
