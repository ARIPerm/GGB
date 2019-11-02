using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    interface IForeignKey
    {
        int GetIdUniver(string UniName, string FacUni);

        int GetIdFac(string FacName, string StudFac);
    }
}
