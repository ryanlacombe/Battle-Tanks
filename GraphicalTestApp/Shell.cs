using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Shell : Entity
    {
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

        public void DetectHit(float deltaTime)
        {
            if (_playerNum == 1 && _shellHitbox.DetectCollision(TankBase.hitboxes.ElementAt(0)))
            {
                Parent.RemoveChild(this);
            }
            else if (_playerNum == 0 && _shellHitbox.DetectCollision(TankBase.hitboxes.ElementAt(1)))
            {
                Parent.RemoveChild(this);
            }
        }
    }
}
