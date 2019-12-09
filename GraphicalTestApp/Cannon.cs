using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Cannon : Actor
    {
        private Sprite _cannonSprite;

        public Cannon(float x, float y)
        {
            _cannonSprite = new Sprite("barrelGreen_outline.png");
            _cannonSprite.Y = -50;
            AddChild(_cannonSprite);
            OnUpdate += RotateCannon;
        }

        public void RotateCannon(float deltaTime)
        {
            if (Input.IsKeyDown(262))
            {
                Rotate(0.5f * deltaTime);
            }
            else if (Input.IsKeyDown(263))
            {
                Rotate(-0.5f * deltaTime);
            }
        }
    }
}
