using System;
using System.Collections.Generic;
using System.Text;

namespace PluginInterface
{
    [AttributeUsage(AttributeTargets.Class)]
    public class PlugDisplayNameAttribute:System.Attribute
    {
        private string _displayname;

        public PlugDisplayNameAttribute(string displayname)
            : base()
        {
            this._displayname = displayname;
            return;
        }

        public override string ToString()
        {
            return _displayname;
        }

    }
}
