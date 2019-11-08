using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    interface IGetDB
    {
        List<string> GetStudent(int PageNumber);

        List<string> GetFaculty(int PageNumber);

        List<string> GetUniversity(int PageNumber);
        
        int countPage { get; }
    }
}
