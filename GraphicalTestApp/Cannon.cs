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
            OnUpdate += Fire;
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

        public void Fire(float deltaTime)
        {
            if (Input.IsKeyPressed(32))
            {
                Shell shell = new Shell(XAbsolute, YAbsolute);
                Vector3 direction = GetDirectionAbsolute();

                shell.Rotate(GetRotationAbsolute());
                shell.X += direction.x * -50f;
                shell.Y += direction.y * -50f;
                shell.XVelocity += direction.x * -300f;
                shell.YVelocity += direction.y * -300f;
                Parent.Parent.AddChild(shell);
            }
        }
    }
}
