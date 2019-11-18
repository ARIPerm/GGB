using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    public interface IGetWeather
    {
        Weather GetWeather(City city, string lang);
    }
}
