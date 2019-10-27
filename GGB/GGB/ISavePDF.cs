using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    public interface ISavePDF
    {

        void Save(List<string> title, List<string> data);


    }
}
