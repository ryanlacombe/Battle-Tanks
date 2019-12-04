using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Tank : Entity
    {
        public Tank(float x, float y) : base(x, y)
        {
            TankBase tank = new TankBase(0, 0);
            AddChild(tank);
        }
    }
}
