using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class StartUp
{
    static void Main(string[] args)
    {
        Controller controller = new Controller();
        Engine engine = new Engine(controller);

        engine.Run();
        Console.ReadKey();
    }
}