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
            _hitbox = new AABB(90, 90);
            AddChild(_tankSprite);
            AddChild(_hitbox);

        }
    }
}
