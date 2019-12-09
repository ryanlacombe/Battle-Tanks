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
            Cannon cannon = new Cannon(0, 0);
            AddChild(tank);
            AddChild(cannon);
            OnUpdate += RotateTank;
        }
        public void RotateTank(float deltaTime)
        {
            if (Input.IsKeyDown(65))
            {
                foreach(Actor child in _children)
                {
                    Rotate(-0.5f * deltaTime);
                }
            }

            else if (Input.IsKeyDown(68))
            {
                foreach (Actor child in _children)
                {
                    Rotate(0.5f * deltaTime);
                }
            }
        }        
    }
}
