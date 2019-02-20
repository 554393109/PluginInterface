using System;
using System.Collections.Generic;
using System.Text;
using PluginInterface;

namespace PluginB
{
    [PlugDisplayName("DisplayNamePluginB")]
    [PlugDescription("DescriptionPlugB")]
    public class PluginB : System.Object, PluginInterface.IShow
    {
        public string Show()
        {
            return "this is PluginB!";
        }

        public PluginB()
            : base()
        {
            return;
        }


    }
}
