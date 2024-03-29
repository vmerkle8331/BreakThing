using System;
using System.Collections.Generic;
using System.Text;

namespace BreakThing
{
    public class Boxer
    {
        public void FightsDrago()
        {
            throw new HeDiesException("Apollo, NOOOOOOOOOO!");
        }
    }
}
