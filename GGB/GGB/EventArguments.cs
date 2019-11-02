using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    public class EventArguments
    {
        public EventArguments(string message) { text = message; }
        public String text { get; set; }
    }
}
