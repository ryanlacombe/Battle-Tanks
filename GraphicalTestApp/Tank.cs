using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Tank : Entity
    {
        Sprite _tankSprite;
        AABB _hitbox;

        public Tank(float x, float y) : base(x, y)
        {
            _tankSprite = new Sprite("tankGreen.png");
            _hitbox = new AABB(155, 140);
            AddChild(_tankSprite);
            AddChild(_hitbox);
        }
    }
}
