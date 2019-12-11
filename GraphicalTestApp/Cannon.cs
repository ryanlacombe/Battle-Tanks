using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Cannon : Actor
    {
        //Creates the variables needed for the Cannon Class
        private Sprite _cannonSprite;
        private int _playerNum;
        private int _shellCount1;
        private int _shellCount2;

        //Creates the Constructor for Cannon
        public Cannon(float x, float y, int playerNum)
        {
            _cannonSprite = new Sprite("sprites/barrelGreen_outline.png");
            _cannonSprite.Y = -50;
            AddChild(_cannonSprite);
            _playerNum = playerNum;
            OnUpdate += RotateCannon;
            OnUpdate += Fire;
        }

        public void RotateCannon(float deltaTime)
        {
            //Checks if the User has the "E" key held down
            if (Input.IsKeyDown(69) && _playerNum == 0)
            {
                //Rotates the cannon clockwise
                Rotate(0.5f * deltaTime);
            }
            //Checks if User has the "Q" key held down
            else if (Input.IsKeyDown(81) && _playerNum == 0)
            {
                //Rotates the cannon counter-clockwise
                Rotate(-0.5f * deltaTime);
            }
            //Checks if User has the "O" key held down
            else if (Input.IsKeyDown(79) && _playerNum == 1)
            {
                //Rotates the cannon clockwise
                Rotate(0.5f * deltaTime);
            }
            //Checks if User has the "U" key held down
            else if (Input.IsKeyDown(85) && _playerNum ==1)
            {
                //Rotates the cannon counter-clockwise
                Rotate(-0.5f * deltaTime);
            }
        }

        public void Fire(float deltaTime)
        {
            //Checks if User pressed the "F" key
            if (Input.IsKeyPressed(70) && _playerNum == 0)
            {
                //Checks if User has already fired 5 times
                if(_shellCount1 < 5)
                {
                    //Creates a shell with its direction
                    Shell shell = new Shell(XAbsolute, YAbsolute, _playerNum);
                    Vector3 direction = GetDirectionAbsolute();

                    //Fires the shell at appropriate rotation, direction, and velocity
                    shell.Rotate(GetRotationAbsolute());
                    shell.X += direction.x * -50f;
                    shell.Y += direction.y * -50f;
                    shell.XVelocity += direction.x * -300f;
                    shell.YVelocity += direction.y * -300f;
                    Parent.Parent.AddChild(shell);

                    //Increases the amount of shells fired by one for reload
                    _shellCount1++;
                }
            }
            //Checks if User has pressed the "R" key
            else if(Input.IsKeyPressed(82) && _playerNum == 0)
            {
                //Reloads the cannon
                _shellCount1 = 0;
            }

            //Checks if the User has pressed the ";" key
            else if (Input.IsKeyPressed(59) && _playerNum == 1)
            {
                //Checks if User has already fired 5 times
                if (_shellCount2 < 5)
                {
                    //Creates a shell with its direction
                    Shell shell = new Shell(XAbsolute, YAbsolute, _playerNum);
                    Vector3 direction = GetDirectionAbsolute();

                    //Fires the shell at appropriate rotation, direction, and velocity
                    shell.Rotate(GetRotationAbsolute());
                    shell.X += direction.x * -50f;
                    shell.Y += direction.y * -50f;
                    shell.XVelocity += direction.x * -300f;
                    shell.YVelocity += direction.y * -300f;
                    Parent.Parent.AddChild(shell);

                    //Increases the amount of shells fired by one for reload
                    _shellCount2++;
                }
            }
            //Checks if User has pressed the "P" key
            else if (Input.IsKeyPressed(80) && _playerNum == 1)
            {
                //Reloads the cannon
                _shellCount2 = 0;
            }
        }

    }
}
