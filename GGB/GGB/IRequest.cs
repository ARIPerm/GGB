using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    public interface IRequest<T>
    {
        void SetRequest(string textRequest);
        List<T> GetResult { get; }
    }
}
