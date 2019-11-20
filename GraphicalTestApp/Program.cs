using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(1280, 760, "Graphical Test Application");

            Actor root = new Actor();
            game.Root = root;

            //## Set up game here ##//
            Entity player = new Entity(640, 320);
            Sprite playerSprite = new Sprite("tankGreen.png");
            AABB hitbox = new AABB(160, 140);

            root.AddChild(player);
            player.AddChild(playerSprite);
            player.AddChild(hitbox);

            game.Run();
        }
    }
}
