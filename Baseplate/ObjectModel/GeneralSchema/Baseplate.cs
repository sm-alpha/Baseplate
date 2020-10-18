using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    public class Baseplate
    {
        public readonly string _name;

        public readonly double _thickness;

        public readonly Steel _steel;

        public Baseplate(string name, double thickness, double width, double height, Steel steel)
        {
            _name = name;
            _thickness = thickness;
            _steel = steel;
        }
    }
}
