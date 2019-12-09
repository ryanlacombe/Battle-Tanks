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

        public Shell(float x, float y) : base(x, y)
        {
            _shellSprite = new Sprite("bulletGreenSilver_outline.png");
            _shellHitbox = new AABB(15, 20);
            AddChild(_shellSprite);
            AddChild(_shellHitbox);
        }
    }
}
