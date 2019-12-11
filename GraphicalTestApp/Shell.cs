using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Shell : Entity
    {
        //Creates the variables needed for the Shell Class
        private Sprite _shellSprite;
        private AABB _shellHitbox;
        private int _playerNum;

        public Shell(float x, float y, int playerNum) : base(x, y)
        {
            _shellSprite = new Sprite("sprites/bulletGreenSilver_outline.png");
            _shellHitbox = new AABB(35, 40);
            _playerNum = playerNum;
            AddChild(_shellSprite);
            AddChild(_shellHitbox);
            OnUpdate += DetectHit;
        }

        //Detects if the shell collides with a tank
        public void DetectHit(float deltaTime)
        {
            AABB _checkBox1 = TankBase.hitboxes.ElementAt(0);
            AABB _checkBox2 = TankBase.hitboxes.ElementAt(1);
            //Checks if the Player 1 shell collided with the Player 2 tank
            if (_checkBox1.Parent.Parent.Parent != null && _playerNum == 1 && _shellHitbox.DetectCollision(_checkBox1))
            {               
                    Parent.RemoveChild(_checkBox1.Parent.Parent);
                    Parent.RemoveChild(this);                             
            }
            //Checks if the Player 2 shell collided with the Player 1 tank
            else if (_checkBox2.Parent.Parent.Parent != null && _playerNum == 0 && _shellHitbox.DetectCollision(_checkBox2))
            {
                Parent.RemoveChild(_checkBox2.Parent.Parent);
                Parent.RemoveChild(this);
            }
        }
    }
}
