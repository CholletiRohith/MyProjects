using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalingaCricket.Exceptions
{
    public class CannotCreatePlayer:MainException
    {
        public CannotCreatePlayer(string message):base(message)
        {

        }
    }
}
