using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class TankBase : Entity
    {
        protected Sprite _tankSprite;
        public AABB _hitbox;
        private int _playerNum;
        static public List<AABB> hitboxes = new List<AABB>();

        public TankBase(float x, float y, int playerNum) : base (x, y)
        {
            _tankSprite = new Sprite("tankGreen.png");
            _hitbox = new AABB(110, 110);
            hitboxes.Insert(playerNum, _hitbox);
            AddChild(_tankSprite);
            AddChild(_hitbox);
            _playerNum = playerNum;
            OnUpdate += Move;
            OnUpdate += SetPosition;
        }
        
        public void Move(float deltaTime)
        {
            if (Input.IsKeyDown(83) && _playerNum == 0)
            {
                YVelocity = 60f;
                
            }
            else if (Input.IsKeyDown(87) && _playerNum == 0)
            {                
                YVelocity = -60f;
            }
            else if (Input.IsKeyDown(75) && _playerNum == 1)
            {
                YVelocity = 60f;

            }
            else if (Input.IsKeyDown(73) && _playerNum == 1)
            {
                YVelocity = -60f;
            }
            else
            {
                XVelocity = 0;
                YVelocity = 0;
            }
        }
        public void SetPosition(float deltaTime)
        {           
                Parent.X = XAbsolute;
                Parent.Y = YAbsolute;

                X = 0;
                Y = 0;            
        }
    }
}
