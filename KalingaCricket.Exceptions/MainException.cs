using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalingaCricket.Exceptions
{
   public class MainException:Exception
    {
        public MainException(string message):base(message)
        {

        }
    }
}
