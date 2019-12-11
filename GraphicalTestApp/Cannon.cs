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
        private int _playerNum;

        public Cannon(float x, float y, int playerNum)
        {
            _cannonSprite = new Sprite("barrelGreen_outline.png");
            _cannonSprite.Y = -50;
            AddChild(_cannonSprite);
            _playerNum = playerNum;
            OnUpdate += RotateCannon;
            OnUpdate += Fire;
        }

        public void RotateCannon(float deltaTime)
        {
            if (Input.IsKeyDown(69) && _playerNum == 0)
            {
                Rotate(0.5f * deltaTime);
            }
            else if (Input.IsKeyDown(81) && _playerNum == 0)
            {
                Rotate(-0.5f * deltaTime);
            }
            else if (Input.IsKeyDown(79) && _playerNum == 1)
            {
                Rotate(0.5f * deltaTime);
            }
            else if (Input.IsKeyDown(85) && _playerNum ==1)
            {
                Rotate(-0.5f * deltaTime);
            }
        }

        public void Fire(float deltaTime)
        {
            if (Input.IsKeyPressed(32))
            {
                Shell shell = new Shell(XAbsolute, YAbsolute, _playerNum);
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
