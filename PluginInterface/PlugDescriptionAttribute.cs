using System;
using System.Collections.Generic;
using System.Text;

namespace PluginInterface
{
    [AttributeUsage(AttributeTargets.Class)]
    public class PlugDescriptionAttribute:System.Attribute
    {
        private string _description;

        public PlugDescriptionAttribute(string description)
            : base()
        {
            _description = description;

            return;
        }

        public override string ToString()
        {
            return _description;
        }
    }
}
