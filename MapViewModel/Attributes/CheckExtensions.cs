using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapViewModel.Attributes
{
    public static class CheckExtensions
    {
        public static bool IsRoot(this Type type)
        {
            return Attribute.IsDefined(type, typeof(RootCheckAttribute));
        }
    }
}
