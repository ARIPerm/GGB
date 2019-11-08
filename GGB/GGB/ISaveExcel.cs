using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    public interface ISaveExcel
    {
        void Save(string path, string title, List<string> titleColumn, List<string> data);
        
        void setErrorListener(ErrorListener listener);

        void InstallExcel();

    }
}
