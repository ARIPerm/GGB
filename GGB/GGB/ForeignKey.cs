using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    class ForeignKey : IForeignKey
    {
        int IForeignKey.GetIdFac(string FacName, string StudFac)
        {
            int index=0;
            if(FacName==StudFac)
            {
                index =0;
            }
            return index;
        }

        int IForeignKey.GetIdUniver(string UniName, string FacUni)
        {
            int index=0;

            return index;
        }
    }
}
