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
        protected AABB _hitbox;

        public TankBase(float x, float y) : base (x, y)
        {
            _tankSprite = new Sprite("tankGreen.png");
            _hitbox = new AABB(120, 120);
            AddChild(_tankSprite);
            AddChild(_hitbox);
            OnUpdate += Move;
            OnUpdate += SetPosition;
        }
        
        public void Move(float deltaTime)
        {
            if (Input.IsKeyDown(83))
            {
                YVelocity = 60f;
                
            }
            else if (Input.IsKeyDown(87))
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
