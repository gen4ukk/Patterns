using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class HeadRobotCreator
    {
        public RobotHead Create(string model) 
        {
            Console.WriteLine(@$"Create Head {model}");
            return new RobotHead { Model = model };
        }
    }

    internal class BodyRobotCreator
    {
        public RobotBody Create(string model)
        {
            Console.WriteLine(@$"Create Body {model}");
            return new RobotBody { Model = model };
        }
    }

    internal class LegsRobotCreator
    {
        public RobotLegs Create(string model)
        {
            Console.WriteLine(@$"Create Legs {model}");
            return new RobotLegs { Model = model };
        }
    }

    internal class RobotCreator
    {
        public Robot Create(RobotHead head, RobotBody body, RobotLegs legs)
        {
            Console.WriteLine(@$"Create Robot");
            return new Robot { RobotHead = head, RobotBody = body, RobotLegs = legs };
        }
    }
}
