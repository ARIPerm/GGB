using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    public class CityUtils
    {
        public double GetLat { get; }
        public double GetLon { get; }


        public static KeyValuePair<double, double> GetLatAndLon(City city)
        {
            

            switch (city.cityType)
            {
                case CityType.Perm:
                    return new KeyValuePair<double, double>(58, 56);
                case CityType.Moscow:
                    return new KeyValuePair<double, double>(56, 28);
                default: throw new Exception();
            }
        }
    }
}
