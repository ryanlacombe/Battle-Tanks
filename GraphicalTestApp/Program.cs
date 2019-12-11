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

            //Sets the game to run
            Tank player = new Tank(640, 320, 0);
            Tank target = new Tank(920, 100, 1);

            root.AddChild(player);
            root.AddChild(target);

            game.Run();
        }
    }
}
