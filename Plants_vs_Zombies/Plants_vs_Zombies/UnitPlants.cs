using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plants_vs_Zombies
{

    public interface UnitPlants
    {


    }
    class Cactus : UnitPlants
    {
        public override string ToString()
        {
            return "C";
        }

    }
    class Azalea : UnitPlants
    {
        public override string ToString()
        {
            return "A";
        }
    }
    class Rose : UnitPlants
    {
        public override string ToString()
        {
            return "R";
        }
    }
}
