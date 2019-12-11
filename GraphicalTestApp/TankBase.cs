using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class TankBase : Entity
    {
        //Creates the variables needed for the TankBase Class
        protected Sprite _tankSprite;
        public AABB _hitbox;
        private int _playerNum;
        static public List<AABB> hitboxes = new List<AABB>();

        public TankBase(float x, float y, int playerNum) : base (x, y)
        {
            _tankSprite = new Sprite("sprites/tankGreen.png");
            _hitbox = new AABB(110, 110);
            hitboxes.Insert(playerNum, _hitbox);
            AddChild(_tankSprite);
            AddChild(_hitbox);
            _playerNum = playerNum;
            OnUpdate += Move;
            OnUpdate += SetPosition;
        }
        
        //Moves the tank in the direction it is facing
        public void Move(float deltaTime)
        {
            //Checks if User has the "S" key held down
            if (Input.IsKeyDown(83) && _playerNum == 0)
            {
                //Moves the tank in reverse of the direction it is facing
                YVelocity = 60f;                
            }
            //Checks if User has the "W" key held down
            else if (Input.IsKeyDown(87) && _playerNum == 0)
            {        
                //Moves the tank forwards in the direction it is facing
                YVelocity = -60f;
            }
            //Checks if User has the "K" key held down
            else if (Input.IsKeyDown(75) && _playerNum == 1)
            {
                //Moves the tank in reverse of the direction it is facing
                YVelocity = 60f;
            }
            //Checks if User has the "I" key held down
            else if (Input.IsKeyDown(73) && _playerNum == 1)
            {
                //Moves the tank forwards in the direction it is facing
                YVelocity = -60f;
            }
            //Checks if no key is held down
            else
            {
                //Stops the tank's movement
                XVelocity = 0;
                YVelocity = 0;
            }
        }

        //Sets the Parent's position to that of the child's position
        public void SetPosition(float deltaTime)
        {           
                Parent.X = XAbsolute;
                Parent.Y = YAbsolute;

                X = 0;
                Y = 0;            
        }
    }
}
