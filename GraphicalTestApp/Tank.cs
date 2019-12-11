using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Tank : Entity
    {
        //Creates the variables needed for the Tank Class
        private int _playerNum;

        public Tank(float x, float y, int playerNum) : base(x, y)
        {
            TankBase tank = new TankBase(0, 0, playerNum);
            Cannon cannon = new Cannon(0, 0, playerNum);
            _playerNum = playerNum;
            AddChild(tank);
            AddChild(cannon);
            OnUpdate += RotateTank;
        }

        //Rotates the tank and all of its children
        public void RotateTank(float deltaTime)
        {
            //Checks if the User has the "A" key held down
            if (Input.IsKeyDown(65) && _playerNum == 0)
            {
                //Rotates all children counter-clockwise
                foreach(Actor child in _children)
                {
                    Rotate(-0.5f * deltaTime);
                }
            }

            //Checks if the User has the "D" key held down
            else if (Input.IsKeyDown(68) && _playerNum == 0)
            {
                //Rotates all children clockwise
                foreach (Actor child in _children)
                {
                    Rotate(0.5f * deltaTime);
                }
            }

            //Checks if the User has the "J" key held down
            else if (Input.IsKeyDown(74) && _playerNum == 1)
            {
                foreach (Actor child in _children)
                {
                    //Rotates all children counter-clockwise
                    Rotate(-0.5f * deltaTime);
                }
            }

            //Checks if the User has the "L" key held down
            else if (Input.IsKeyDown(76) && _playerNum == 1)
            {
                //Rotates all children clockwise
                foreach (Actor child in _children)
                {
                    Rotate(0.5f * deltaTime);
                }
            }
        }        
    }
}
