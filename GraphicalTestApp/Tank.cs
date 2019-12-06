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
        public void SetPosition(float x, float y)
        {
            foreach (Actor child in _children)
            {
                x = child.X;
                y = child.Y;

                child.X = 0;
                child.Y = 0;
            }
        }
    }
}
