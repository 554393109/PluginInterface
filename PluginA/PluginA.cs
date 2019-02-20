using System;
using System.Collections.Generic;
using System.Text;
using PluginInterface;

namespace PluginA
{
    [PlugDisplayName("DisplayNamePlugA")]
    [PlugDescription("DescriptionPlugA")]
    public class PluginA : System.Object, PluginInterface.IShow
    {
        public string Show()
        {
            return "I am is  PluginA!";
        }

        public PluginA()
            : base()
        {
            return;
        }
    }
}
