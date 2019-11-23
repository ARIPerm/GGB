using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    public class University
    {
        public string GetNameUniversity { get; }
        public int GetIndex { get; }

        public University(string nameUniversity, int index)
        {
            this.GetNameUniversity = nameUniversity;
            this.GetIndex = index;
        }
    }
}
