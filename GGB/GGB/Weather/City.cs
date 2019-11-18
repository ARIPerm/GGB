using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    public class City
    {
        private string name;
        public CityType cityType { get; }

        public City(string name)
        {
            this.name = name;
            this.cityType = Utils.GetCityTypeByName(name);
        }
    }

    public enum CityType
    {
        Perm,
        Moscow
    }
}
