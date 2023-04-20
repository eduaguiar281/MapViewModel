using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapViewModel.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class AggregateCheckAttribute: Attribute
    {
    }
}
