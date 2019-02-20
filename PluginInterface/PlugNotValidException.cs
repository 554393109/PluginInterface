using System;
using System.Collections.Generic;
using System.Text;

namespace PluginInterface
{
    public class PlugNotValidException : Exception
    {

        public PlugNotValidException(System.Type _type, string _message)
            : base("The Plugin " + _type.Name + "Is Not NotValid\r\n" + _message)
        {
            return;
        }
    }
}
